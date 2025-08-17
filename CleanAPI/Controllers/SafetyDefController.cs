using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyDefController(ISafetyDef service) : BaseController<SafetyDef>(service)
    {

    }
}
