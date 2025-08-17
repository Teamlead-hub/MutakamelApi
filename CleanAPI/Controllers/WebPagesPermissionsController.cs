using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WebPagesPermissionsController(IWebPagesPermissions service) : BaseController<WebPagesPermissions>(service)
    {
    }
}
