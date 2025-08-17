using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PmvtsController(IPmvtsService service) : BaseController<Pmvts>(service)
    {
    }
}
