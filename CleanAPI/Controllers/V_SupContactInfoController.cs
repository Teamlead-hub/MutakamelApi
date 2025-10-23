using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_SupContactInfoController(IV_SupContactInfo service) : BaseController<V_SupContactInfo>(service)
    {

    }
}
