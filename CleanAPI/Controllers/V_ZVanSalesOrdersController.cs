using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ZVanSalesOrdersController(IV_ZVanSalesOrdersService service) : BaseController<V_ZVanSalesOrders>(service)
    {
    }
}
