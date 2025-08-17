using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SupComplaintInfoController(ISupComplaintInfo service) : BaseController<SupComplaintInfo>(service)
    {

    }
}
