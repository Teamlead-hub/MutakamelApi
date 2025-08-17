using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class TestMethodsController(ITestMethodsService service) : BaseController<TestMethods>(service)
    {
    }
}
