using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ZVanSalesPaymentController(IV_ZVanSalesPaymentService service) : BaseController<V_ZVanSalesPayment>(service)
    {
    }
}
