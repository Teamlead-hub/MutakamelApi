using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PerfumeController(IPerfumeService service) : BaseController<Perfume>(service)
    {
    }
}
