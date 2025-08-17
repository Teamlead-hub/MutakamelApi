using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeavesRequestController(ILeavesRequest service) : BaseController<LeavesRequest>(service)
    {
    }
}
