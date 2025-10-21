using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_EmploansController(IV_Emploans service) : BaseController<V_Emploans>(service)
    {
    }
}
