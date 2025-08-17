using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyRiskController(ISafetyRisk service) : BaseController<SafetyRisk>(service)
    {

    }
}
