using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{  
    public class LcDocsController(ILcDocs service) : BaseController<LcDocs>(service)
    {

    }
}
