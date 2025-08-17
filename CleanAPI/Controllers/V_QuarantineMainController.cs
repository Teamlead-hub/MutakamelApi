using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_QuarantineMainController(IV_QuarantineMain service) : BaseController<V_QuarantineMain>(service)
    {

    }
}
