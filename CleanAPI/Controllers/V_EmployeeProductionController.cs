using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_EmployeeProductionController(IV_EmployeeProductionService service) :BaseController<V_EmployeeProduction>(service)
    {
    }
}
