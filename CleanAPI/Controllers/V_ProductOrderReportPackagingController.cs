using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductOrderReportPackagingController(IV_ProductOrderReportPackagingService service) : BaseController<V_ProductOrderReportPackaging>(service)
    {

    }
}
