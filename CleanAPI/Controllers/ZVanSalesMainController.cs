using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CleanAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZVanSalesMainController : BaseController<ZVanSalesMain>
    {
        private readonly IRootService<ZVanSalesMain> _service;

        public ZVanSalesMainController(IZVanSalesMainService service) : base(service)
        {
            _service = service;
        }

        [HttpPost("UpsertByVoucher")]
        public async Task<IActionResult> UpsertByVoucher([FromBody] ZVanSalesMain entity)
        {
            try
            {
                using (var transaction = await _service.BeginTransactionAsync())
                {
                    var existing = await _service.FirstOrDefaultAsync(x => x.PInvvocuherId == entity.PInvvocuherId);

                    if (existing != null)
                    {
                        if (entity.Rowversion != null && !entity.Rowversion.SequenceEqual(existing.Rowversion))
                        {
                            return Conflict("The entity has been modified by someone else.");
                        }

                        _service.Delete(existing.Id);

                        await _service.SaveChangesAsync(); // flush the delete
                    }

                    await _service.InsertAsync(entity);
                    await _service.SaveChangesAsync(); // <--- THIS IS MISSING

                    await transaction.CommitAsync();

                    return Ok(entity);
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict("Concurrency conflict occurred.");
            }
            catch (Exception ex)
            {
                var innermost = ex;
                while (innermost.InnerException != null)
                    innermost = innermost.InnerException;

                return StatusCode(500, innermost.Message);
            }
        }
    
    
    }
}
