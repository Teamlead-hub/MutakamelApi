using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ActiveProductionEmployeesController(IV_ActiveProductionEmployeesService service) : BaseController<V_ActiveProductionEmployees>(service)
    {
    }
}
