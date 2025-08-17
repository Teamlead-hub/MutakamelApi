using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_VouchersController(IV_Vouchers service) : BaseController<V_Vouchers>(service)
    {
    }
}
