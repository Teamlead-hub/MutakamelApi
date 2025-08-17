using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductWithdrawalController(IProductWithdrawal service) : BaseController<ProductWithdrawal>(service)
    {

    }
}
