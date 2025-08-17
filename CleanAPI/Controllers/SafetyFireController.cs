using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyFireController(ISafetyFire service) : BaseController<SafetyFire>(service)
    {

    }
}
