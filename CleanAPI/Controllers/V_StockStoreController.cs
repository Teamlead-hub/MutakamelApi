using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockStoreController(IV_StockStoreService service): BaseController<V_StockStore>(service)
    {
    }
}
