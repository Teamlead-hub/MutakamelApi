using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductPackagingMaterialController(IProductPackagingMaterialService service) : BaseController<ProductPackagingMaterial>(service)
    {

    }
}
