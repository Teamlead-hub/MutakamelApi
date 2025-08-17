using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MasterProductionScheduleController(IV_MasterProductionScheduleService service) :BaseController<V_MasterProductionSchedule>(service)
    {
    }
}
