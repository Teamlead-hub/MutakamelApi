using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SubAssetsTestMethodMainController(IV_SubAssetsTestMethodMainService service) : BaseController<V_SubAssetsTestMethodMain>(service)
    {
    }
}
