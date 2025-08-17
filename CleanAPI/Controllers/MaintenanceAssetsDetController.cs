using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceAssetsDetController(IMaintenanceAssetsDet service) : BaseController<MaintenanceAssetsDet>(service)
    {
    }
}
