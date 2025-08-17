using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_StabilityController(IV_StabilityService service) : BaseController<V_Stability>(service)
    {
    }
}
