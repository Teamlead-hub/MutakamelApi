using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AssetsDestructionController(IV_AssetsDestruction service) : BaseController<V_AssetsDestruction>(service)
    {
    }
}
