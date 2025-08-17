using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_IncrementMainController(IV_IncrementMain service) : BaseController<V_IncrementMain>(service)
    {
    }
}
