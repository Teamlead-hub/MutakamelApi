using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_CinvvoucherController(IV_Cinvvoucher service) : BaseController<V_Cinvvoucher>(service)
    {
    }
}
