using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_PinvvoucherController(IV_PinvvoucherService service) : BaseController<V_Pinvvoucher>(service)
    {
    }
}
