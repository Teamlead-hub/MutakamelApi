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
    public class V_SupplierInfoService : RootService<V_SupplierInfo>, IV_SupplierInfo
    {
        public V_SupplierInfoService(IRepository<V_SupplierInfo> repository) : base(repository)
        {
        }

    }
}
