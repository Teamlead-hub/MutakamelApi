using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockSupplierController(IV_StockSupplierService service) : BaseController<V_StockSupplier>(service)
    {
    }
}
