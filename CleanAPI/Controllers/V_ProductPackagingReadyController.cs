using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductPackagingReadyController(IV_ProductPackagingReadyService service) : BaseController<V_ProductPackagingReady>(service)
    {

    }
}
