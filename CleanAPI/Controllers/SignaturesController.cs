using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SignaturesController(ISignatures service) : BaseController<Signatures>(service)
    {

    }
}
