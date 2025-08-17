using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_stockController(IV_stockService service) : BaseController<V_stock>(service)
    {
    }
}
