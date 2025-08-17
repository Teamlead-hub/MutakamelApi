using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CustomerCategoryController(ICustomerCategory service) : BaseController<CustomerCategory>(service)
    {
    }
}
