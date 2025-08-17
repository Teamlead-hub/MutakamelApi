using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockPurchaseController(IV_StockPurchaseService service) : BaseController<V_StockPurchase>(service)
    {
    }
}
