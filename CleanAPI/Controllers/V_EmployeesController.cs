using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_EmployeesController(IV_Employees service) : BaseController<V_Employees>(service)
    {
    }
}
