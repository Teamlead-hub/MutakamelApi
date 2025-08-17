using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceRequestMainController(IMaintenanceRequestMain service) : BaseController<MaintenanceRequestMain>(service)
    {
    }
}
