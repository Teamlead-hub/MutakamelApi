using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SalesOrderDetController(IV_SalesOrderDet service) : BaseController<V_SalesOrderDet>(service)
    {
    }
}
