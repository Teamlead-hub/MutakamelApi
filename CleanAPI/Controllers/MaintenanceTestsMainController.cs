using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceTestsMainController(IMaintenanceTestsMain service) : BaseController<MaintenanceTestsMain>(service)
    {
    }
}
