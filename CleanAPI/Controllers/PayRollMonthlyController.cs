using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PayRollMonthlyController(IPayRollMonthly service) : BaseController<PayRollMonthly>(service)
    {
    }
}
