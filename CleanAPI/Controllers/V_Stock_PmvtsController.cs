using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_Stock_PmvtsController(IV_Stock_PmvtsService service) : BaseController<V_Stock_Pmvts>(service)
    {
    }
}
