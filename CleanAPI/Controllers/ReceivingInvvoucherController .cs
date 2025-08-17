using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ReceivingInvvoucherController(IReceivingInvvoucher service) : BaseController<ReceivingInvvoucher>(service)
    {
    }
}
