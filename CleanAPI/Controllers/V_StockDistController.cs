using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockDistController(IV_StockDistService service) : BaseController<V_StockDist>(service)
    {
    }
}
