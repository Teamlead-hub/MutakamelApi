using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosPaidInController(IPosPaidInService service) : BaseController<PosPaidIn>(service)
    {
    }
}
