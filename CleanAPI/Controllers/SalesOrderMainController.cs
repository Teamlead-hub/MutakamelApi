using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SalesOrderMainController(ISalesOrderMain service) : BaseController<SalesOrderMain>(service)
    {
    }
}
