using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SalaryIncreaseRequestController(IV_SalaryIncreaseRequest service) : BaseController<V_SalaryIncreaseRequest>(service)
    {
    }
}
