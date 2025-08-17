using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AssetsController(IV_Assets service) : BaseController<V_Assets>(service)
    {
    }
}
