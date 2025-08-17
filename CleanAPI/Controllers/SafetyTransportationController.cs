using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyTransportationController(ISafetyTransportation service) : BaseController<SafetyTransportation>(service)
    {

    }
}
