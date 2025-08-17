using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class VouchersTypeController(IVouchersTypeService service) : BaseController<VouchersType>(service)
    {
    }
}
