using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CustomerContactController(ICustomerContactService service) :BaseController<CustomerContact>(service)
    {
    }
}
