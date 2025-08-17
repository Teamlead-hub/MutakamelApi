using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaterialRequirementsPlanningController(IMaterialRequirementsPlanningService service) :BaseController<MaterialRequirementsPlanning>(service)
    {
    }
}
