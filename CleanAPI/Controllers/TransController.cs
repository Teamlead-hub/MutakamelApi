using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class TransController(ITrans service) : BaseController<Trans>(service)
    {
    }
}
