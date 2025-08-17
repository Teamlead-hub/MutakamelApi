using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class EmpAllowanceController(IEmpAllowance service) : BaseController<EmpAllowance>(service)
    {
    }
}
