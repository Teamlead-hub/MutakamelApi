using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LoginPosDetController(ILoginPosDet service) : BaseController<LoginPosDet>(service)
    {
    }
}
