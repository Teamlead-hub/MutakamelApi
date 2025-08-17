using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CurrencyController(ICurrencyService service):BaseController<Currency>(service)
    {
    }
}
