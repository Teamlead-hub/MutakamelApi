using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MasterProductionScheduleDetController(IV_MasterProductionScheduleDetService service) :BaseController<V_MasterProductionScheduleDet>(service)
    {
    }
}
