using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_WeeklyPlanDetEmployeesController(IV_WeeklyPlanDetEmployeesService service) : BaseController<V_WeeklyPlanDetEmployees>(service)
    {
    }
}
