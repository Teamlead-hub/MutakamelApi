using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ZVanSalesPaymentController(IZVanSalesPaymentService service) : BaseController<ZVanSalesPayment>(service)
    {
    }
}
