using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductOrderController(IV_ProductOrderService service) : BaseController<V_ProductOrder>(service)
    {
    }
}
