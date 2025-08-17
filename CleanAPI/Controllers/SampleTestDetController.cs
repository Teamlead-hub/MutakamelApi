using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SampleTestDetController(ISampleTestDet service) : BaseController<SampleTestDet>(service)
    {

    }
}
