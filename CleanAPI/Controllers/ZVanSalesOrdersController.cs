using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class ZVanSalesOrdersController(IZVanSalesOrdersService service) : BaseController<ZVanSalesOrders>(service)
    {
    }
}
