using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceTypeController(IMaintenanceType service) : BaseController<MaintenanceType>(service)
    {
    }
}
