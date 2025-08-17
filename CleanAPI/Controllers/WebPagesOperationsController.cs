using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WebPagesOperationsController(IWebPagesOperations service) : BaseController<WebPagesOperations>(service)
    {
    }
}
