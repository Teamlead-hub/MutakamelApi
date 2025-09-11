using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductsBarcodesController(IV_ProductsBarcodesService service) : BaseController<V_ProductsBarcodes>(service)
    {
    }
}
