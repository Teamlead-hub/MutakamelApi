using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WebPagesController(IWebPagesService service) : BaseController<WebPages>(service)
    {
    }
}
