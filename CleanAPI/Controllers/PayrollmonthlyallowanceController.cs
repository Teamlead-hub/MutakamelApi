using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PayrollmonthlyallowanceController(IPayrollmonthlyallowance service) : BaseController<Payrollmonthlyallowance>(service)
    {
    }
}
