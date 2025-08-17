using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductOrderRawMaterialController(IProductOrderRawMaterialService service):BaseController<ProductOrderRawMaterial>(service)
    {
    }
}
