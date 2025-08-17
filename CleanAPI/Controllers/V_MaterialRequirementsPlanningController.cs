using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaterialRequirementsPlanningController(IV_MaterialRequirementsPlanningService service) :BaseController<V_MaterialRequirementsPlanning>(service)
    {
    }
}
