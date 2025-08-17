using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ZVanSalesDetailsController(IV_ZVanSalesDetailsService service) : BaseController<V_ZVanSalesDetails>(service)
    {
    }
}
