using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaintenanceTestsDetController(IV_MaintenanceTestsDet service) : BaseController<V_MaintenanceTestsDet>(service)
    {
    }
}
