using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetsCatController(IAssetsCat service) : BaseController<AssetsCat>(service)
    {
    }
}
