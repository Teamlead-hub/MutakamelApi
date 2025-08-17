using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_VanInvoiceDetailsController(IV_VanInvoiceDetailsService service) : BaseController<V_VanInvoiceDetails>(service)
    {
    }
}
