using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyAidController(ISafetyAid service) : BaseController<SafetyAid>(service)
    {

    }
}
