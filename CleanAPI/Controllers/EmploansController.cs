using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class EmploansController(IEmploans service) : BaseController<Emploans>(service)
    {
    }
}
