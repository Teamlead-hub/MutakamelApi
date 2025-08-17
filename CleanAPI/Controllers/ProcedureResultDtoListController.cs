using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    public class ProcedureResultListDtoController(IProcedureResultListDtoService service) : BaseController<ProcedureResultListDto>(service)
    {
        [HttpPost("SendProcedureResults")]
        public IActionResult SendProcedureResults([FromBody] List<ProcedureResultListDto> data)
        {
            if (data == null || data.Count == 0)
            {
                return Ok("Success");
            }

            var transformedData = data.Select(d => new { Id = d.Result.FirstOrDefault()?["Id"] ?? "Success" }).ToList();

            return Ok(transformedData);
        }
    }
}
