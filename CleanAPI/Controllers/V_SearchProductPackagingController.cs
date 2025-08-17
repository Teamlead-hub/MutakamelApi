using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_SearchProductPackagingController(IV_SearchProductPackagingService service) : BaseController<V_SearchProductPackaging>(service)
    {

    }
}
