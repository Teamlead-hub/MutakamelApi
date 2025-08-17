using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceAgenciesController(IMaintenanceAgencies service) : BaseController<MaintenanceAgencies>(service)
    {
    }
}
