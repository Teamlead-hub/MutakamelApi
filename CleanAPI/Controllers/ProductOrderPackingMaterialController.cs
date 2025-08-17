using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductOrderPackingMaterialController(IProductOrderPackingMaterialService service):BaseController<ProductOrderPackingMaterial>(service)
    {
    }
}
