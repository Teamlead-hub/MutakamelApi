using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_voucherAccountsController(IV_voucherAccounts service) : BaseController<V_voucherAccounts>(service)
    {
    }
}
