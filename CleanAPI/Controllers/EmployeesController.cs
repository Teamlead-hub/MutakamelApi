using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class EmployeesController(IEmployees service) : BaseController<Employees>(service)
    {
    }
}
