using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ProductLineController(IProductLineService service) : BaseController<ProductLine>(service)
    {
    }
}
