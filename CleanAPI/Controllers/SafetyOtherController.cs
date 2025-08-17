using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyOtherController(ISafetyOther service) : BaseController<SafetyOther>(service)
    {

    }
}
