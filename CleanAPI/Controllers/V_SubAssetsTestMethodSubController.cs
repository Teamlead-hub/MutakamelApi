using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SubAssetsTestMethodSubController(IV_SubAssetsTestMethodSubService service) : BaseController<V_SubAssetsTestMethodSub>(service)
    {
    }
}
