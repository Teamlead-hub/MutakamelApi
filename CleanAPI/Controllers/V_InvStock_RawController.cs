using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_InvStock_RawController(IV_InvStock_RawService service) :BaseController<V_InvStock_Raw>(service)
    {
    }
}
