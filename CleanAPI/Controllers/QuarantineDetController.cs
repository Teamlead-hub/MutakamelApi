using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class QuarantineDetController(IQuarantineDet service) : BaseController<QuarantineDet>(service)
    {

    }
}
