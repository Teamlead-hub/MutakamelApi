using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_LeavesDetailsController(IV_LeavesDetails service) : BaseController<V_LeavesDetails>(service)
    {
    }
}
