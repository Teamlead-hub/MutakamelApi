using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_LeavesRequestController(IV_LeavesRequest service) : BaseController<V_LeavesRequest>(service)
    {
    }
}
