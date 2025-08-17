using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class OverTimeMainController(IOverTimeMain service) : BaseController<OverTimeMain>(service)
    {
    }
}
