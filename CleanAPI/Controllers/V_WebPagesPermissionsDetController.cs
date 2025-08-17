using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_WebPagesPermissionsDetController(IV_WebPagesPermissionsDet service) : BaseController<V_WebPagesPermissionsDet>(service)
    {
    }
}
