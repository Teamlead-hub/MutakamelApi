using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetDepreciationDetailsController(IAssetDepreciationDetails service) : BaseController<AssetDepreciationDetails>(service)
    {
    }
}
