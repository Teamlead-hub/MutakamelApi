using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SectionsController(ISections service) : BaseController<Sections>(service)
    {
    }
}
