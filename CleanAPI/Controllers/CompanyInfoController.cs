using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CompanyInfoController(ICompanyInfo service) : BaseController<CompanyInfo>(service)
    {
    }
}
