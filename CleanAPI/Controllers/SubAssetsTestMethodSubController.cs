using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SubAssetsTestMethodSubController(ISubAssetsTestMethodSubService service) : BaseController<SubAssetsTestMethodSub>(service)
    {
    }
}
