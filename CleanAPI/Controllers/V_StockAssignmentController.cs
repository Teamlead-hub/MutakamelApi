using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_StockAssignmentController(IV_StockAssignment service) : BaseController<V_StockAssignment>(service)
    {

    }
}
