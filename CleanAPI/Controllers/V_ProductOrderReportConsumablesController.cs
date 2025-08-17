using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductOrderReportConsumablesController(IV_ProductOrderReportConsumablesService service) : BaseController<V_ProductOrderReportConsumables>(service)
    {

    }
}
