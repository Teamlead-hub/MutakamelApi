using CleanBase;
using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_WebpagesSignaturesController(IV_WebpagesSignatures service) : BaseController<V_WebpagesSignatures>(service)
    {
    }
}
