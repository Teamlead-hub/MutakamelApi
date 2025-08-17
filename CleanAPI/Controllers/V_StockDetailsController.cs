using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockDetailsController(IV_StockDetailsService service) : BaseController<V_StockDetails>(service)
    {
    }
}
