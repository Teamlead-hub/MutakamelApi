using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyDisposalController(ISafetyDisposal service) : BaseController<SafetyDisposal>(service)
    {

    }
}
