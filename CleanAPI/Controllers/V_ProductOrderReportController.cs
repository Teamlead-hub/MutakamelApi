using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductOrderReportController(IV_ProductOrderReport service) : BaseController<V_ProductOrderReport>(service)
    {

    }
}
