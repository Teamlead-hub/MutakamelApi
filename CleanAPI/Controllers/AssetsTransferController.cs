using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetsTransferController(IAssetsTransfer service) : BaseController<AssetsTransfer>(service)
    {
    }
}
