using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductstestController(IProductstestService service) : BaseController<Productstest>(service)
    {
    }
}
