using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_PayRollMonthlyController(IV_PayRollMonthly service) : BaseController<V_PayRollMonthly>(service)
    {
    }
}
