using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_VanInvoiceMainController(IV_VanInvoiceMainService service) : BaseController<V_VanInvoiceMain>(service)
    {
    }
}
