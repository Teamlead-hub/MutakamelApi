using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SpecificationsController(IV_SpecificationsService service) : BaseController<V_Specifications>(service)
    {
    }
}
