using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductPackagingController(IV_ProductPackagingService service) : BaseController<V_ProductPackaging>(service)
    {
    }
}
