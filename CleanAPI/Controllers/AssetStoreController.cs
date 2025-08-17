using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetStoreController(IAssetStore service) : BaseController<AssetStore>(service)
    {

    }
}
