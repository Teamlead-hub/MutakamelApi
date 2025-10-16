using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class LoginPosController(ILoginPos service) : BaseController<LoginPos>(service)
    {
    }
}
