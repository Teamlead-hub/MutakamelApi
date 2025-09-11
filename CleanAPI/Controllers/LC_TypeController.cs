using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{ 
    public class LC_TypeController(ILC_Type service) : BaseController<LC_Type>(service)
    {

    }
}
