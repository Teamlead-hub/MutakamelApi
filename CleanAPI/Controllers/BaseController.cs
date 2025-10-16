using CleanBase;
using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Transactions;

using Serilog;
using System.Threading.Tasks.Dataflow;
using System.Collections;
using CleanOperation.Declarations;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;


namespace CleanAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase where T : class, IEntityRoot
    {
        private readonly IRootService<T> _service;
        private readonly TransformBlock<List<T>, List<T>> _insertBlock;
        public BaseController(IRootService<T> service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableQuery]

        public IActionResult Get()
        {
            try
            {
                return Ok(_service.Query());
            }
            catch (Exception ex)
            {
                // Get the innermost exception
                Exception innermostException = ex;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                // Log the innermost exception message
                Log.Error(innermostException.Message);

                // Return a 500 Internal Server Error with the innermost exception message
                return StatusCode(500, innermostException.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] T entity)
        {
            if (entity == null)
            {
                return BadRequest("Entity cannot be null.");
            }

            try
            {
                // Initialize the TransformBlock for processing insert requests
                var insertBlock = new TransformBlock<T, T>(async e =>
                {
                    return await _service?.InsertAsync(e);
                });

                // Optionally, link to an ActionBlock for logging or further processing
                var actionBlock = new ActionBlock<T>(result =>
                {
                    // Log the successful insert or handle further actions
                    Console.WriteLine($"Successfully inserted: {result.Id}");
                });

                insertBlock.LinkTo(actionBlock, new DataflowLinkOptions { PropagateCompletion = true });

                // Post the entity to the block for processing
                insertBlock.Post(entity);

                // Mark the block as complete (can be done after all entities are posted)
                insertBlock.Complete();

                // Await the completion of the action block
                await actionBlock.Completion;

                // Return the result
                return Ok(entity);
            }
            catch (Exception ex)
            {
                // Get the innermost exception
                Exception innermostException = ex;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                // Log the innermost exception message
                Log.Error(innermostException.Message);

                // Return a 500 Internal Server Error with the innermost exception message
                return StatusCode(500, innermostException.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] T entity)
        {

            //var result = _service.Update(entity);
            //return Ok(result.Entity);

            var result = _service.UpdateWithChildrenn(entity);
            return Ok(result.Entity);

        }



        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                // Example delete operation using raw SQL
                _service.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                // Handle the exception
                Exception innermostException = ex;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                Log.Error(innermostException.Message);
                return StatusCode(500, innermostException.Message);
            }

        }


        [HttpDelete("MainDet")]
        public IActionResult MainDet([FromBody] T entity)
        {
            try
            {
                _service.Delete(entity);

                return Ok(entity);

            }
            catch (Exception ex)
            {
                // Get the innermost exception
                Exception innermostException = ex;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                // Log the innermost exception message
                Log.Error(innermostException.Message);

                // Return a 500 Internal Server Error with the innermost exception message
                return StatusCode(500, innermostException.Message);
            }
        }

        [HttpPost("executeList")]
        public async Task<IActionResult> ExecuteStoredProcedureList([FromBody] ExecuteRequest request)
        {
            try
            {
                // Validate the request
                if (request == null || string.IsNullOrWhiteSpace(request.StoredProcedureName) || request.Parameters == null)
                {
                    return BadRequest("Invalid request.");
                }

                // Execute the stored procedure and return the result
                var res = await _service.ExecuteAsync<ProcedureResultListDto>(request.StoredProcedureName, request.Parameters);

                return Ok(res);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("execute")]
        public async Task<IActionResult> ExecuteStoredProcedure([FromBody] ExecuteRequest request)
        {
            try
            {
                // Validate the request
                if (request == null || string.IsNullOrWhiteSpace(request.StoredProcedureName) || request.Parameters == null)
                {
                    return BadRequest("Invalid request."); // Return 400 if the request is invalid
                }

                // Create a TaskCompletionSource to capture the result
                var tcs = new TaskCompletionSource<object>();

                // Initialize the TransformBlock for processing the stored procedure execution
                var executeBlock = new TransformBlock<ExecuteRequest, object>(async req =>
                {
                    var result = await _service.Execute(req.StoredProcedureName, req.Parameters);
                    tcs.TrySetResult(result); // Set the result in the TaskCompletionSource
                    return result; // Return the result for linking
                });

                // Optionally, link to an ActionBlock for logging or further processing
                var actionBlock = new ActionBlock<object>(result =>
                {
                    // Handle the result or log it
                    if (result != null)
                    {
                        Console.WriteLine($"Executed stored procedure, result: {result}");
                    }
                });

                // Link the blocks
                executeBlock.LinkTo(actionBlock, new DataflowLinkOptions { PropagateCompletion = true });

                // Post the request to the block for processing
                executeBlock.Post(request);

                // Mark the block as complete
                executeBlock.Complete();

                // Await the TaskCompletionSource for the result
                var finalResult = await tcs.Task;

                if (finalResult == null)
                {
                    return NotFound("No results found."); // Return 404 if no results were returned
                }

                // Handle different result types
                switch (finalResult)
                {
                    case IEnumerable<object> listResult:
                        Console.WriteLine($"List of results: {listResult.Count()} items");
                        return Ok(listResult);  // Return 200 with the list of objects

                    case object singleResult:
                        Console.WriteLine($"Single object result: {singleResult}");
                        return Ok(singleResult);  // Return 200 with the single object

                    default:
                        return BadRequest("Unexpected result type.");
                }
            }
            catch (Exception ex)
            {
                // Get the innermost exception
                Exception innermostException = ex;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                // Log the innermost exception message
                Log.Error(innermostException.Message);

                // Return a 500 Internal Server Error with the innermost exception message
                return StatusCode(500, innermostException.Message);
            }
        }


        [HttpPost("DeleteAndSave")]
        public async Task<IActionResult> DeleteAndSave([FromBody] T entity)
        {
            // Validate the incoming request

            try
            {
                // Start a new transaction scope for both delete and insert operations
                using (var transaction = await _service.BeginTransactionAsync())
                {

                    // Delete the specified entity
                    await _service.DeleteAsync(entity);

                    // Insert the new entity
                    var result = await _service.InsertAsync(entity);

                    // Commit changes for both operations
                    await _service.SaveChangesAsync();

                    // Complete the transaction scope
                    await transaction.CommitAsync();

                    return Ok(result); // Return the result of the insert operation
                }
            }

            catch (DbUpdateException dbEx)
            {
                // Get the innermost exception
                Exception innermostException = dbEx;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                // Log the innermost exception message
                Log.Error(innermostException.Message);

                // Return a 500 Internal Server Error with the innermost exception message
                return StatusCode(500, innermostException.Message);

            }
            catch (Exception ex)
            {
                // Get the innermost exception
                Exception innermostException = ex;
                while (innermostException.InnerException != null)
                {
                    innermostException = innermostException.InnerException;
                }

                // Log the innermost exception message
                Log.Error(innermostException.Message);

                // Return a 500 Internal Server Error with the innermost exception message
                return StatusCode(500, innermostException.Message);

            }
        }






        //------------------------------------- Post Without TransfromBlock  ------------

        //[HttpPut]
        //public IActionResult Post([FromBody] T entity)
        //{
        //    try
        //    {
        //        var result = await _service.InsertAsync(entity);
        //        return Ok(result.Entity);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(ex.InnerException.Message);

        //        // Return a 500 Internal Server Error with a generic message
        //        return StatusCode(500, $"{ex.InnerException.Message}");
        //    }
        //}
        //------------------------------------- Post Without TransfromBlock ------------


        //[HttpPost("[action]")]
        //public async Task<IActionResult> InsertList([FromBody] List<T> entity)
        //{
        //    try
        //    {
        //        await _service.InsertAsync(entity);
        //        return Ok(entity);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(ex.InnerException.Message);

        //        // Return a 500 Internal Server Error with a generic message
        //        return StatusCode(500, $"{ex.InnerException.Message}");
        //    }
        //}

        //------------------------------------- this is without check contain list details is done ------------

        //[HttpPost("DeleteAndSave")]
        //public async Task<IActionResult> DeleteAndSave([FromBody] DeleteAndSaveRequest<T> request)
        //{
        //    // Validate the incoming request
        //    if (request == null || request.EntityToDelete == null || request.EntityToSave == null)
        //    {
        //        return BadRequest("Invalid request: must provide both entities.");
        //    }

        //    try
        //    {
        //        // Start a new transaction scope for both delete and insert operations
        //        using (var transaction = await _service.BeginTransactionAsync())
        //        {
        //            // Delete the specified entity
        //            await _service.DeleteAsync(request.EntityToDelete);

        //            // Insert the new entity
        //            var result = await _service.InsertAsync(request.EntityToSave);

        //            // Commit changes for both operations
        //            await _service.SaveChangesAsync();

        //            // Complete the transaction scope
        //            await transaction.CommitAsync();

        //            return Ok(result); // Return the result of the insert operation
        //        }
        //    }
        //    catch (DbUpdateException dbEx)
        //    {
        //        return StatusCode(500, new { Message = "An error occurred while saving changes.", Details = dbEx.InnerException?.Message });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { Message = "An error occurred.", Details = ex.Message });
        //    }
        //}




        //------------------------------------------- this is with check contain list details is done ---------------------

        //[HttpPost("DeleteAndSave")]
        //public async Task<IActionResult> DeleteAndSaveInternal(DeleteAndSaveRequest<T> request)
        //{
        //    if (request == null || request.EntityToDelete == null || request.EntityToSave == null)
        //    {
        //        return BadRequest("Invalid request: must provide both entities.");
        //    }

        //    var existingEntityToDelete = _service.Get(request.EntityToDelete.Id);
        //    if (existingEntityToDelete == null)
        //    {
        //        return NotFound("Entity to delete not found.");
        //    }

        //    using (var transaction = await _service.BeginTransactionAsync())
        //    {
        //        try
        //        {
        //            // Handle deletion of related entities
        //            var properties = typeof(T).GetProperties();
        //            foreach (var property in properties)
        //            {
        //                if (property.PropertyType.IsGenericType &&
        //                    (property.PropertyType.GetGenericTypeDefinition() == typeof(List<>) ||
        //                     property.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)))
        //                {
        //                    var collection = property.GetValue(existingEntityToDelete) as IEnumerable<object>;
        //                    if (collection != null)
        //                    {
        //                        foreach (var item in collection)
        //                        {
        //                            var itemType = item.GetType();
        //                            var deleteMethod = typeof(IRootService<>).MakeGenericType(itemType).GetMethod("DeleteAsync");
        //                            if (deleteMethod != null)
        //                            {
        //                                await (Task)deleteMethod.Invoke(_service, new[] { item });
        //                            }
        //                        }
        //                    }
        //                }
        //            }

        //            // Now delete the main entity
        //            await _service.DeleteAsync(existingEntityToDelete);

        //            // Save the new entity
        //            var result = await _service.InsertAsync(request.EntityToSave);
        //            await _service.SaveChangesAsync();

        //            // Commit the transaction
        //            await transaction.CommitAsync();

        //            return Ok(result);
        //        }
        //        catch (Exception ex)
        //        {
        //            await transaction.RollbackAsync(); // Rollback on error
        //            return StatusCode(500, new { Message = "An error occurred.", Details = ex.Message });
        //        }
        //    }
        //}

        //-----------------------------------------------------------one entity-------------------








        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IEnumerable<IFormFile> files, [FromQuery] string directory = "upload")
        {
            if (files == null || !files.Any())
            {
                return BadRequest("No files uploaded.");
            }

            try
            {
                // Combine directory with the base path to create a dynamic folder structure
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), directory);
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath); // Create directory if it doesn't exist
                }

                var filePaths = new List<string>();
                var fileNames = new List<string>(); // To store the new file names for the response

                foreach (var file in files)
                {
                    if (file.Length == 0)
                        continue;

                    // Generate a unique file name to avoid collisions
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(uploadPath, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }

                    filePaths.Add(filePath);
                    fileNames.Add(fileName); // Add the new file name to the response
                }

                // Return the new file names in the response
                return Ok(new { FilePaths = filePaths, FileNames = fileNames });
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500, "An error occurred while uploading the files.");
            }
        }



        [HttpDelete("deleteFiles")]
        public IActionResult DeleteImage(string fileName, string directory)
        {
            if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(directory))
            {
                return BadRequest("File name and directory must be provided.");
            }

            try
            {
                // Construct the path using the dynamic directory
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), directory);
                var filePath = Path.Combine(uploadPath, fileName);

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                System.IO.File.Delete(filePath);

                return Ok("File deleted successfully.");  // Return a string response
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500, "An error occurred while deleting the file.");
            }
        }



        //---------------

        [HttpGet("getFiles")]
        public IActionResult GetFiles([FromQuery] string directory = "upload")
        {
            if (string.IsNullOrEmpty(directory))
            {
                return BadRequest(new { Message = "Directory parameter is required." });
            }

            try
            {
                // Combine the base directory with the passed directory parameter
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), directory);

                // Ensure the directory exists (create if missing)
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    return Ok(new List<object>()); // return empty list
                }

                // Get all files in the directory and prepare the response
                var files = Directory.GetFiles(folderPath)
                    .Select(filePath => new
                    {
                        FileName = Path.GetFileName(filePath),
                        FileUrl = $"{Request.Scheme}://{Request.Host}/{directory.Replace("\\", "/")}/{Path.GetFileName(filePath)}"
                    })
                    .ToList();

                return Ok(files);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving the files.", Error = ex.Message });
            }
        }




        //-------------------------------


        //-------------------------------

        //[HttpGet("getPag")]
        //public async Task<IActionResult> Get([FromQuery] RequestFilters filters)
        //{
        //    // Thread.Sleep(6000);
        //    try
        //    {
        //        //  return Ok(_service.Query());
        //        return Ok(await _service.GetPagedAsync(filters));
        //    }
        //    catch (Exception ex)
        //    {
        //        // Get the innermost exception
        //        Exception innermostException = ex;
        //        while (innermostException.InnerException != null)
        //        {
        //            innermostException = innermostException.InnerException;
        //        }
        //        // Log the innermost exception message
        //        Log.Error(innermostException.Message);
        //        // Return a 500 Internal Server Error with the innermost exception message
        //        return StatusCode(500, innermostException.Message);
        //    }
        //}



    }

}
