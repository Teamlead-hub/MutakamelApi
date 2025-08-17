using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductOrder_InvVoucherController(IV_ProductOrder_InvVoucherService service) : BaseController<V_ProductOrder_InvVoucher>(service)
    {

    }
}
