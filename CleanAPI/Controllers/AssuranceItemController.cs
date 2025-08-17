using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssuranceItemController(IAssuranceItem service) : BaseController<AssuranceItem>(service)
    {
    }
}
