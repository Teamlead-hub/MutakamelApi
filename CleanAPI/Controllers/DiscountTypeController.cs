using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class DiscountTypeController(IDiscountType service) : BaseController<DiscountType>(service)
    {
    }
}
