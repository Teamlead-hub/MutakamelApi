using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaintenanceRequestDetController(IV_MaintenanceRequestDet service) : BaseController<V_MaintenanceRequestDet>(service)
    {
    }
}
