using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class CashBudgetController(ICashBudgetService service) : BaseController<CashBudget>(service)
    {
    }
}
