using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProcedureResultDtoController(IProcedureResultDtoService service) : BaseController<ProcedureResultDto>(service)
    {
    }
}
