using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class WebpagesSignaturesController(IWebpagesSignatures service) : BaseController<WebpagesSignatures>(service)
    {
    }
}
