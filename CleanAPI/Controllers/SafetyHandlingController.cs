using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyHandlingController(ISafetyHandling service) : BaseController<SafetyHandling>(service)
    {

    }
}
