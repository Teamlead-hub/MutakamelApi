using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PaymentMethodController(IPaymentMethodService service) :BaseController<PaymentMethod>(service)
    {
    }
}
