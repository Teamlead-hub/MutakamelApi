using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductOrderReportWagesController(IProductOrderReportWages service) : BaseController<ProductOrderReportWages>(service)
    {

    }
}
