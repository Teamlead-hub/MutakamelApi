using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaintenanceAssetsDetController(IV_MaintenanceAssetsDet service) : BaseController<V_MaintenanceAssetsDet>(service)
    {
    }
}
