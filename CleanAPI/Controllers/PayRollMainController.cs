using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PayRollMainController(IPayRollMain service) : BaseController<PayRollMain>(service)
    {
    }
}
