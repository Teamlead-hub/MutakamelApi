using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_LeavesMainController(IV_LeavesMain service) : BaseController<V_LeavesMain>(service)
    {
    }
}
