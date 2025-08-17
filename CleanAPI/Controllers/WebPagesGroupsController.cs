using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WebPagesGroupsController(IWebPagesGroups service) : BaseController<WebPagesGroups>(service)
    {
    }
}
