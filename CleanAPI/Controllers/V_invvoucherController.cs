using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_invvoucherController(IV_invvoucher service) : BaseController<V_invvoucher>(service)
    {
    }
}
