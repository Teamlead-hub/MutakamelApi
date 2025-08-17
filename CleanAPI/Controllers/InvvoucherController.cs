using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class InvvoucherController(IInvvoucher service) : BaseController<Invvoucher>(service)
    {
    }
}
