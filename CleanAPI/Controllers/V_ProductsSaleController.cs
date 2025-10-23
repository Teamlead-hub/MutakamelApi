using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductsSaleController(IV_ProductsSaleService service) : BaseController<V_ProductsSale>(service)
    {
    }
}
