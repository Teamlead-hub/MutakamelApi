using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class StockTypeController(IStockType service) : BaseController<StockType>(service)
    {

    }
}
