using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductsBarcodesController(IProductsBarcodesService service) : BaseController<ProductsBarcodes>(service)
    {
    }
}
