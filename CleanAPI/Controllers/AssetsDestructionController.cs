using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetsDestructionController(IAssetsDestruction service) : BaseController<AssetsDestruction>(service)
    {
    }
}
