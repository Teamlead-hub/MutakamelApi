using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosInvoiceDetailController(IPosInvoiceDetailService service) : BaseController<PosInvoiceDetail>(service)
    {
    }
}
