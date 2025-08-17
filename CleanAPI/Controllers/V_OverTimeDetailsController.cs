using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_OverTimeDetailsController(IV_OverTimeDetails service) : BaseController<V_OverTimeDetails>(service)
    {
    }
}
