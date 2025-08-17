using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class stockController(IstockService service) : BaseController<Stock>(service)
    {
    }
}
