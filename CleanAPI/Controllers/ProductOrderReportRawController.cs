using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductOrderReportRawController(IProductOrderReportRaw service) : BaseController<ProductOrderReportRaw>(service)
    {

    }
}
