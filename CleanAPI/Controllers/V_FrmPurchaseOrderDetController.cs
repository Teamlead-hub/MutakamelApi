using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_FrmPurchaseOrderDetController(IV_FrmPurchaseOrderDet service) : BaseController<V_FrmPurchaseOrderDet>(service)
    {
    }
}
