using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_QuarantineDetController(IV_QuarantineDet service) : BaseController<V_QuarantineDet>(service)
    {

    }
}
