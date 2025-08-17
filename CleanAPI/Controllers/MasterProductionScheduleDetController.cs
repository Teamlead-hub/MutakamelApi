using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MasterProductionScheduleDetController(IMasterProductionScheduleDetService service) :BaseController<MasterProductionScheduleDet>(service)
    {
    }
}
