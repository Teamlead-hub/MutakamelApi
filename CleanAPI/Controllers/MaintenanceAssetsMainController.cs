using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceAssetsMainController(IMaintenanceAssetsMain service) : BaseController<MaintenanceAssetsMain>(service)
    {
    }
}
