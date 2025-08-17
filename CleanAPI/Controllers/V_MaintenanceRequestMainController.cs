using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaintenanceRequestMainController(IV_MaintenanceRequestMain service) : BaseController<V_MaintenanceRequestMain>(service)
    {
    }
}
