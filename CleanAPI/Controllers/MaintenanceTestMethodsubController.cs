using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceTestMethodsubController(IMaintenanceTestMethodsub service) : BaseController<MaintenanceTestMethodsub>(service)
    {
    }
}
