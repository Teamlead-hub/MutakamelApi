using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductPackagingMaterialController(IV_ProductPackagingMaterialService service) : BaseController<V_ProductPackagingMaterial>(service)
    {

    }
}
