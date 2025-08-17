using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeavesDetailsController(ILeavesDetails service) : BaseController<LeavesDetails>(service)
    {
    }
}
