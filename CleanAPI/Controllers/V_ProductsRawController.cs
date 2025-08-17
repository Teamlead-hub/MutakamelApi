using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductsRawController(IV_ProductsRawService service):BaseController<V_ProductsRaw>(service)
    {
    }
}
