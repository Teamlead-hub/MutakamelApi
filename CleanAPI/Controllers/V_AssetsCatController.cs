using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AssetsCatController(IV_AssetsCat service) : BaseController<V_AssetsCat>(service)
    {
    }
}
