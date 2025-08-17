using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_CustomerContactController(IV_CustomerContactService service) :BaseController<V_CustomerContact>(service)
    {
    }
}
