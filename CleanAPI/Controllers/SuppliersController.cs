using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SuppliersController(ISuppliersService service) : BaseController<Suppliers>(service)

    {
    }
}
