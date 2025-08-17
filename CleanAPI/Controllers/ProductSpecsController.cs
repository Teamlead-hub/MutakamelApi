using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductSpecsController(IProductSpecsService service) : BaseController<ProductSpecs>(service)
    {
    }
}
