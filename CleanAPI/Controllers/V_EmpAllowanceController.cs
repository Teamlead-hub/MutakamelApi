using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_EmpAllowanceController(IV_EmpAllowance service) : BaseController<V_EmpAllowance>(service)
    {
    }
}
