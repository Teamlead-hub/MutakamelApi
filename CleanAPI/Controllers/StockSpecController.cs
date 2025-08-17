using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StockSpecController(IStockSpecService service) : BaseController<StockSpec>(service)
    {
    }
}
