using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductOrderPackagingController(IProductOrderPackagingService service):BaseController<ProductOrderPackaging>(service)
    {
    }
}
