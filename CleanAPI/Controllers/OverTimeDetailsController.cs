using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class OverTimeDetailsController(IOverTimeDetails service) : BaseController<OverTimeDetails>(service)
    {
    }
}
