using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductLineController(IV_ProductLineService service) : BaseController<V_ProductLine>(service)
    {
    }
}
