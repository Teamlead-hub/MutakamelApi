using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductsController(IV_ProductsService service) : BaseController<V_Products>(service)
    {
    }
}
