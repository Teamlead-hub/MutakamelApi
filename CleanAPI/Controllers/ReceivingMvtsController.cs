using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ReceivingMvtsController(IReceivingMvts service) : BaseController<ReceivingMvts>(service)
    {
    }
}
