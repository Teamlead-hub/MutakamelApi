using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SafetyChemicalController(ISafetyChemical service) : BaseController<SafetyChemical>(service)
    {

    }
}
