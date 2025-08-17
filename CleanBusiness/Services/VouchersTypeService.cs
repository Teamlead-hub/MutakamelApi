using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using Microsoft.EntityFrameworkCore;

namespace CleanBusiness.Services
{
    public class VouchersTypeService : RootService<VouchersType>, IVouchersTypeService
    {
        public VouchersTypeService(IRepository<VouchersType> repository) : base(repository)
        {
           
        }

    }
}
