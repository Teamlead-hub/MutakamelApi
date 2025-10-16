using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosVoidDetailsController(IPosVoidDetailsService service) : BaseController<PosVoidDetails>(service)
    {
    }
}
