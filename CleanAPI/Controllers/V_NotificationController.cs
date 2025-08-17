using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_NotificationController(IV_NotificationService service) : BaseController<V_Notification>(service)
    {
    }
}
