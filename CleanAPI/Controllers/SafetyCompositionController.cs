using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyCompositionController(ISafetyComposition service) : BaseController<SafetyComposition>(service)
    {

    }
}
