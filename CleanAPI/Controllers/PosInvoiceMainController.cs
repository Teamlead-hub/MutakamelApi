using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosInvoiceMainController(IPosInvoiceMainService service) : BaseController<PosInvoiceMain>(service)
    {
    }
}
