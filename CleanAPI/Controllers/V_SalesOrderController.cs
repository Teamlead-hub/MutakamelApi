using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SalesOrderController(IV_SalesOrder service) : BaseController<V_SalesOrder>(service)
    {
    }
}
