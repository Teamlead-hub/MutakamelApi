using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AccountsStatementsController(IAccountsStatements service) : BaseController<AccountsStatements>(service)
    {
    }
}
