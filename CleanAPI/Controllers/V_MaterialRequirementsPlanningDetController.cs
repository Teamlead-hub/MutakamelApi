using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaterialRequirementsPlanningDetController(IV_MaterialRequirementsPlanningDetService service) : BaseController<V_MaterialRequirementsPlanningDet>(service)
    {
    }
}
