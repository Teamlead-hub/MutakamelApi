using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class VanInvoiceMainController(IVanInvoiceMainService service) : BaseController<VanInvoiceMain>(service)
    {
    }
}
