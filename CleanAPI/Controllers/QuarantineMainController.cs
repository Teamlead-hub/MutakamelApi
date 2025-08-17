using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class QuarantineMainController(IQuarantineMain service) : BaseController<QuarantineMain>(service)
    {

    }
}
