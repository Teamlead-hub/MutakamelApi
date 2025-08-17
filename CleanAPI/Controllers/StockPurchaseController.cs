using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StockPurchaseController(IStockPurchaseService service) : BaseController<StockPurchase>(service)
    {
    }
}
