using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SpecificationsController(ISpecificationsService service) : BaseController<Specifications>(service)
    {
    }
}
