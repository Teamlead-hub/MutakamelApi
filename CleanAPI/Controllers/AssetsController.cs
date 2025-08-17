using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetsController(IAssets service) : BaseController<Assets>(service)
    {
    }
}
