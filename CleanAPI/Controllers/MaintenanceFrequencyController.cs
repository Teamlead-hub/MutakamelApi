using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceFrequencyController(IMaintenanceFrequency service) : BaseController<MaintenanceFrequency>(service)
    {
    }
}
