using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AssetDepreciationDetailsController(IV_AssetDepreciationDetails service) : BaseController<V_AssetDepreciationDetails>(service)
    {
    }
}
