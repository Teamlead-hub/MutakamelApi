using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ColorController(IColorService service) : BaseController<Color>(service)
    {
    }
}
