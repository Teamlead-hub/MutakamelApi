using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductOrderReportPackagingController(IProductOrderReportPackagingService service) : BaseController<ProductOrderReportPackaging>(service)
    {

    }
}
