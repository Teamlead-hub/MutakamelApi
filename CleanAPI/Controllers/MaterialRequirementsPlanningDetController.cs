using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaterialRequirementsPlanningDetController(IMaterialRequirementsPlanningDetService service) :BaseController<MaterialRequirementsPlanningDet>(service)
    {
    }
}
