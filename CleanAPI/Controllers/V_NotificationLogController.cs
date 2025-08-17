using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_NotificationLogController(IV_NotificationLogService service) : BaseController<V_NotificationLog>(service)   
    {
    }
}



