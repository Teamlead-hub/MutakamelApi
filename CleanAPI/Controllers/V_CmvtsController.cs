using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_CmvtsController(IV_Cmvts service) : BaseController<V_Cmvts>(service)
    {
    }
}
