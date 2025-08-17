using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class VouchersController(IVouchers service) : BaseController<Vouchers>(service)
    {
    }
}
