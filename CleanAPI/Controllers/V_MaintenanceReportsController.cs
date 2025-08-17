using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaintenanceReportsController(IV_MaintenanceReports service) : BaseController<V_MaintenanceReports>(service)
    {
    }
}
