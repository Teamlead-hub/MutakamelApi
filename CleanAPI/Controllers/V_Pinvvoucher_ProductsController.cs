using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_Pinvvoucher_ProductsController(IV_Pinvvoucher_ProductsService service) : BaseController<V_Pinvvoucher_Products>(service)
    {
    }
}
