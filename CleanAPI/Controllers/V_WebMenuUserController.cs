using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_WebMenuUserController(IV_WebMenuUserService service) : BaseController<V_WebMenuUser>(service)
    {
    }
}
