using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductOrderReportWagesController(IV_ProductOrderReportWages service) : BaseController<V_ProductOrderReportWages>(service)
    {

    }
}
