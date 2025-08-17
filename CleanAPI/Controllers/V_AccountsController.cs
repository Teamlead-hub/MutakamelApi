using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AccountsController(IV_Accounts service) : BaseController<V_Accounts>(service)
    {
    }
}
