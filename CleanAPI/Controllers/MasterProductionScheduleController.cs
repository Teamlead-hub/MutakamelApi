using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MasterProductionScheduleController(IMasterProductionScheduleService service) :BaseController<MasterProductionSchedule>(service)
    {
    }
}
