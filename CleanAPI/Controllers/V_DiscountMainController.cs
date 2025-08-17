using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_DiscountMainController(IV_DiscountMain service) : BaseController<V_DiscountMain>(service)
    {
    }
}
