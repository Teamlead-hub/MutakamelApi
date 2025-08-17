using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SpecificationLabTestsController(ISpecificationLabTestsService service) : BaseController<SpecificationLabTests>(service)
    {

    }
}
