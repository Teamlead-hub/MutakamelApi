using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_SpecificationLabTestsController(IV_SpecificationLabTestsService service) : BaseController<V_SpecificationLabTests>(service)
    {

    }
}
