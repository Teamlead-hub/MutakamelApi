using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductPackagingController(IProductPackagingService service) : BaseController<ProductPackaging>(service)
    {
    }
}
