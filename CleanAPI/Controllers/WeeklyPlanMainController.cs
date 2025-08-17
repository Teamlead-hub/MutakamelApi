using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WeeklyPlanMainController(IWeeklyPlanMainService service) : BaseController<WeeklyPlanMain>(service)
    {
    }
}
