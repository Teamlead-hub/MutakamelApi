using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class ProductOrderWagesController(IProductOrderWagesService service) :BaseController<ProductOrderWages>(service)
    {
    }
}
