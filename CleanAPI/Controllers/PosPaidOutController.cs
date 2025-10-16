using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosPaidOutController(IPosPaidOutService service) : BaseController<PosPaidOut>(service)
    {
    }
}
