using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosVoucherDetailsController(IPosVoucherDetailsService service) : BaseController<PosVoucherDetails>(service)
    {
    }
}
