using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class HrSectionsController(IHrSections service) : BaseController<HrSections>(service)
    {
    }
}
