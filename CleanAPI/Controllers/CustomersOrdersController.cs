using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class CustomersOrdersController(ICustomersOrdersService service) : BaseController<CustomersOrders>(service)
    {
    }
}
