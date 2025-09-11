using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class V_CinvvoucherService : RootService<V_Cinvvoucher>, IV_Cinvvoucher
    {
        public V_CinvvoucherService(IRepository<V_Cinvvoucher> repository) : base(repository)
        { }
    }
}
