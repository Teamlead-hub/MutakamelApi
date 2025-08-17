using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ZVanSalesDetailsController(IZVanSalesDetailsService service) : BaseController<ZVanSalesDetails>(service)
    {
    }
}
