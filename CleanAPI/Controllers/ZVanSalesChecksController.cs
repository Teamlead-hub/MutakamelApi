using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ZVanSalesChecksController(IZVanSalesChecksService service) : BaseController<ZVanSalesChecks>(service)
    {
    }
}
