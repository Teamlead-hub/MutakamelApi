using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_IncrementDetailsController(IV_IncrementDetails service) : BaseController<V_IncrementDetails>(service)
    {
    }
}
