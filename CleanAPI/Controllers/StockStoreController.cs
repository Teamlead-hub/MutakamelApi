using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StockStoreController(IStockStoreService service) : BaseController<StockStore>(service)
    {
    }
}
