using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_ProductOrder_mvtsController(IV_ProductOrder_mvtsService service) : BaseController<V_ProductOrder_mvts>(service)
    {
    }
}
