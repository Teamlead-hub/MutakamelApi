using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class LabTestResulteController(ILabTestResulte service) : BaseController<LabTestResulte>(service)
    {

    }
}
