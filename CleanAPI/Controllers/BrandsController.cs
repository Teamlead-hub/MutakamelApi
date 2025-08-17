using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class BrandsController(IBrandsService service) : BaseController<Brands>(service)
    {
    }
}
