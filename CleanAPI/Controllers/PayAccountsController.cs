using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PayAccountsController(IPayAccounts service) : BaseController<PayAccounts>(service)
    {
    }
}
