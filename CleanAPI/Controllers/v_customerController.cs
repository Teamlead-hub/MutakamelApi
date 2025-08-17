using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class v_customerController(Iv_customer service) : BaseController<v_customer>(service)
    {
    }
}
