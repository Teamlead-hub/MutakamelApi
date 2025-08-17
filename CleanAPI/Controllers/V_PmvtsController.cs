using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_PmvtsController(IV_PmvtsService service) : BaseController<V_Pmvts>(service)
    {
    }
}
