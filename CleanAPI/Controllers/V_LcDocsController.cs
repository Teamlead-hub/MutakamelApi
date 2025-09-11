using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    public class V_LcDocsController(IV_LcDocs service) : BaseController<V_LcDocs>(service)
    {

    }
}
