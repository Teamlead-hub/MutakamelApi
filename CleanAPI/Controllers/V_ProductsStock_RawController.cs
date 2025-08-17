using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductsStock_RawController(IV_ProductsStock_RawService service) :BaseController<V_ProductsStock_Raw>(service)
    {
    }
}
