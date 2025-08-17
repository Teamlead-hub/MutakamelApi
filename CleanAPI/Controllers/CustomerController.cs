using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class CustomerController(ICustomer service) : BaseController<Customer>(service)
    {

    }
}
