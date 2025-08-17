using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_CustomersOrdersController(IV_CustomersOrdersService service) : BaseController<V_CustomersOrders>(service)
    {
    }
}
