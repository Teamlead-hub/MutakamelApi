using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_FrmPurchaseOrderController(IV_FrmPurchaseOrder service) : BaseController<V_FrmPurchaseOrder>(service)
    {
    }
}
