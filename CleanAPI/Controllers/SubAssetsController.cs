using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SubAssetsController(ISubAssets service) : BaseController<SubAssets>(service)
    {
    }
}
