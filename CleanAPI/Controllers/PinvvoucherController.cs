using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PinvvoucherController(IPinvvoucherService service) : BaseController<Pinvvoucher>(service)
    {
    }
}
