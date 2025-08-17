using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class DiscountDetailsController(IDiscountDetails service) : BaseController<DiscountDetails>(service)
    {
    }
}
