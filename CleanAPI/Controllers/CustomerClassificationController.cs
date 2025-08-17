using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CustomerClassificationController(ICustomerClassificationService service) :BaseController<CustomerClassification>(service)
    {
    }
}
