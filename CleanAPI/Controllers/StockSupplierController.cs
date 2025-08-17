using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StockSupplierController(IStockSupplierService service) : BaseController<StockSupplier>(service)
    {
    }
}
