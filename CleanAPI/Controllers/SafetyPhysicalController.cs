using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyPhysicalController(ISafetyPhysical service) : BaseController<SafetyPhysical>(service)
    {

    }
}
