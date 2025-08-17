using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class DiscountMainController(IDiscountMain service) : BaseController<DiscountMain>(service)
    {
    }
}
