using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SampletestMainController(ISampletestMain service) : BaseController<SampletestMain>(service)
    {

    }
}
