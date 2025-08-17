using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class webpagesUsersController(IwebpagesUsers service) : BaseController<webpagesUsers>(service)
    {
        
    }
}
