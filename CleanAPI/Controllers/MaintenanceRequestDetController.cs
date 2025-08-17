using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceRequestDetController(IMaintenanceRequestDet service) : BaseController<MaintenanceRequestDet>(service)
    {
    }
}
