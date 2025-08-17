using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class IncrementMainController(IIncrementMain service) : BaseController<IncrementMain>(service)
    {
    }
}
