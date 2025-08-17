using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WeeklyPlanDetController(IWeeklyPlanDetService service) : BaseController<WeeklyPlanDet>(service)
    {
    }
}
