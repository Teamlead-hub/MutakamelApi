using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_WeeklyPlanMainController(IV_WeeklyPlanMainService service) : BaseController<V_WeeklyPlanMain>(service)
    {
    }
}
