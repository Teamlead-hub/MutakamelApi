using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockSpecController(IV_StockSpecService service) : BaseController<V_StockSpec>(service)
    {
    }
}
