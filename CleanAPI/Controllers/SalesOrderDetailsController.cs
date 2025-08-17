using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SalesOrderDetailsController(ISalesOrderDetails service) : BaseController<SalesOrderDetails>(service)
    {
    }
}
