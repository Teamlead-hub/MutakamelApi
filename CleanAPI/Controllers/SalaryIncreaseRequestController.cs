using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SalaryIncreaseRequestController(ISalaryIncreaseRequest service) : BaseController<SalaryIncreaseRequest>(service)
    {
    }
}
