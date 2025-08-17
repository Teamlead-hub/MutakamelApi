using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class AccountsController(IAccounts service) : BaseController<Accounts>(service)
    {

    }
}
