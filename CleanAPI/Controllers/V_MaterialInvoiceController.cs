using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_MaterialInvoiceController(IV_MaterialInvoiceService service) :BaseController<V_MaterialInvoice>(service)
    {
    }
}
