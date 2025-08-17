using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductsController(IProductsService service) : BaseController<Products>(service)
    {
    }
}
