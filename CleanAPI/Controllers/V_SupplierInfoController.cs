using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_SupplierInfoController(IV_SupplierInfo service) : BaseController<V_SupplierInfo>(service)
    {

    }
}
