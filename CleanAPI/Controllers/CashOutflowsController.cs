using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class CashOutflowsController(ICashOutflowsService service) : BaseController<CashOutflows>(service)
    {
    }
}
