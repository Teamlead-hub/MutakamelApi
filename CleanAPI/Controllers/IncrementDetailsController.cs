using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class IncrementDetailsController(IIncrementDetails service) : BaseController<IncrementDetails>(service)
    {
    }
}
