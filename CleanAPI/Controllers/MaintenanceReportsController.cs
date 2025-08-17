using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintenanceReportsController(IMaintenanceReports service) : BaseController<MaintenanceReports>(service)
    {
    }
}
