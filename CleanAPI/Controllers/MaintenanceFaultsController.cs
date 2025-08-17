using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceFaultsController(IMaintenanceFaults service) : BaseController<MaintenanceFaults>(service)
    {
    }
}
