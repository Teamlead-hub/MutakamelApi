using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductsRawController(IProductsRawService service):BaseController<ProductsRaw>(service)
    {
    }
}
