using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_ReceivingMvtsController(IV_ReceivingMvts service) : BaseController<V_ReceivingMvts>(service)
    {
    }
}
