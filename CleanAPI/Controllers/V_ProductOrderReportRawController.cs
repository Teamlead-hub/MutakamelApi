using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductOrderReportRawController(IV_ProductOrderReportRaw service) : BaseController<V_ProductOrderReportRaw>(service)
    {

    }
}
