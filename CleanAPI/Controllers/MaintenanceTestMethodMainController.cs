using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceTestMethodMainController(IMaintenanceTestMethodMain service) : BaseController<MaintenanceTestMethodMain>(service)
    {
    }
}
