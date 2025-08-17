using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class VanInvoiceDetailsController(IVanInvoiceDetailsService service) : BaseController<VanInvoiceDetails>(service)
    {
    }
}
