using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_mvtsController(IV_mvts service) : BaseController<V_mvts>(service)
    {
    }
}
