using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyCompositionDetController(ISafetyCompositionDet service) : BaseController<SafetyCompositionDet>(service)
    {

    }
}
