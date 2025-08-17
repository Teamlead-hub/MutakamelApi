using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ZVanSalesMainController(IV_ZVanSalesMainService service) : BaseController<V_ZVanSalesMain>(service)
    {
    }
}
