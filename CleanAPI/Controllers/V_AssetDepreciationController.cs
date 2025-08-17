using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AssetDepreciationController(IV_AssetDepreciation service) : BaseController<V_AssetDepreciation>(service)
    {
    }
}
