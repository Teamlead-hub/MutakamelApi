using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeavesMainController(ILeavesMain service) : BaseController<LeavesMain>(service)
    {
    }
}
