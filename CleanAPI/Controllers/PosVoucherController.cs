using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosVoucherController(IPosVoucherService service) : BaseController<PosVoucher>(service)
    {
    }
}
