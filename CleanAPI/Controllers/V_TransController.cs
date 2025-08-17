using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_TransController(IV_Trans service) : BaseController<V_Trans>(service)
    {
    }
}
