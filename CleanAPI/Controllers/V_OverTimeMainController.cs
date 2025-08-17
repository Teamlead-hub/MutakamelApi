using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_OverTimeMainController(IV_OverTimeMain service) : BaseController<V_OverTimeMain>(service)
    {
    }
}
