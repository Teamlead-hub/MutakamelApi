using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductOrderPackagingController(IV_ProductOrderPackagingService service):BaseController<V_ProductOrderPackaging>(service)
    {
    }
}
