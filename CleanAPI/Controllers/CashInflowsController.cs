using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class CashInflowsController(ICashInflowsService service) : BaseController<CashInflows>(service)
    {
    }
}
