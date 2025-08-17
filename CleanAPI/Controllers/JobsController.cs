using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class JobsController(IJobs service) : BaseController<Jobs>(service)
    {
    }
}
