using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class CashBudgetItemsController(ICashBudgetItemsService service) : BaseController<CashBudgetItems>(service)
    {
    }
}
