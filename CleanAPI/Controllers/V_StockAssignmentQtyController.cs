using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_StockAssignmentQtyController(IV_StockAssignmentQty service) : BaseController<V_StockAssignmentQty>(service)
    {

    }
}
