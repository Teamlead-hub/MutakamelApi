using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StockDetailsController(IStockDetailsService service) : BaseController<StockDetails>(service)
    {
    }
}
