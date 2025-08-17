using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StockTestController(IStockTestService service) : BaseController<StockTest>(service)
    {
    }
}
