using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class LabsController(ILabs service) : BaseController<Labs>(service)
    {

    }
}
