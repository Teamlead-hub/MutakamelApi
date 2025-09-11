using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CInvvoucherController(ICInvvoucher service) : BaseController<CInvvoucher>(service)
    {
    }
}
