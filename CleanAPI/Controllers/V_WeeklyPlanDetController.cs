using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_WeeklyPlanDetController(IV_WeeklyPlanDetService service) : BaseController<V_WeeklyPlanDet>(service)
    {
    }
}
