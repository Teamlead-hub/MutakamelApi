using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_mvts_ProductOrderPackagingController(IV_mvts_ProductOrderPackagingService service) : BaseController<V_mvts_ProductOrderPackaging>(service)
    {
    }
}
