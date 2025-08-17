using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductOrderController(IProductOrderService service) : BaseController<ProductOrder>(service)
    {
    }
}
