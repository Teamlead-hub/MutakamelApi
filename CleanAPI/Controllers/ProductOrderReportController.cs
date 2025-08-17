using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductOrderReportController(IProductOrderReport service) : BaseController<ProductOrderReport>(service)
    {

    }
}
