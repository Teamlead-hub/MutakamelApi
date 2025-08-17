using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceTestsDetController(IMaintenanceTestsDet service) : BaseController<MaintenanceTestsDet>(service)
    {
    }
}
