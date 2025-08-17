using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class NotificationController(INotificationService service) : BaseController<Notification>(service)
    {
    }
}
