using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    public class lC_STATUSController(IlC_STATUS service) : BaseController<lC_STATUS>(service)
    {

    }
}
