using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class StockAssignmentController(IStockAssignment service) : BaseController<StockAssignment>(service)
    {

    }
}
