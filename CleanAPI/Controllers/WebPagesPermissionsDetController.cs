using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WebPagesPermissionsDetController(IWebPagesPermissionsDet service) : BaseController<WebPagesPermissionsDet>(service)
    {
    }
}
