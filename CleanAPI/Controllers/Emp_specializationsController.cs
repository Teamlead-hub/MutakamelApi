using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class Emp_specializationsController(IEmp_specializations service) : BaseController<Emp_specializations>(service)
    {
    }
}
