using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetDepreciationController(IAssetDepreciation service) : BaseController<AssetDepreciation>(service)
    {
    }
}
