using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SubAssetsTestMethodMainController(ISubAssetsTestMethodMainService service) : BaseController<SubAssetsTestMethodMain>(service)
    {
    }
}
