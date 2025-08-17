using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockTestController(IV_StockTestService service) : BaseController<V_StockTest>(service)
    {
    }
}
