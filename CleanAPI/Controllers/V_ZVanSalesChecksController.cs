using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ZVanSalesChecksController(IV_ZVanSalesChecksService service) : BaseController<V_ZVanSalesChecks>(service)
    {
    }
}
