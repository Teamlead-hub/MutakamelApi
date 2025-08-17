using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class DeptController(IDept service) : BaseController<Dept>(service)
    {
    }
}
