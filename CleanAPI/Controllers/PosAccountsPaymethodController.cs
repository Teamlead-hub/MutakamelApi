using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosAccountsPaymethodController(IPosAccountsPaymethodService service) : BaseController<PosAccountsPaymethod>(service)
    {
    }
}
