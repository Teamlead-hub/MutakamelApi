using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyToxicityController(ISafetyToxicity service) : BaseController<SafetyToxicity>(service)
    {

    }
}
