using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_CompanyInfoController(IV_CompanyInfo service) : BaseController<V_CompanyInfo>(service)
    {
    }
}
