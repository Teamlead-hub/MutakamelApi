using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SubAssetsController(IV_SubAssets service) : BaseController<V_SubAssets>(service)
    {
    }
}
