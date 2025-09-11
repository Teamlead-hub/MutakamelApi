using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class CashBalanceController(ICashBalanceService service) : BaseController<CashBalance>(service)
    {
    }
}
