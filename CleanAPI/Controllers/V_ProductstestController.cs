using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductstestController(IV_ProductstestService service) : BaseController<V_Productstest>(service)
    {
    }
}
