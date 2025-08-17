using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AllowanceController(IAllowance service) : BaseController<Allowance>(service)
    {
    }
}
