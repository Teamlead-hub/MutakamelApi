using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class StabilityController(IStabilityService service) : BaseController<Stability>(service)
    {
    }
}
