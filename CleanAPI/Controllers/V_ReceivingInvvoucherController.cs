using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_ReceivingInvvoucherController(IV_ReceivingInvvoucher service) : BaseController<V_ReceivingInvvoucher>(service)
    {
    }
}
