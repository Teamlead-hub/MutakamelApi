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
    public class V_ProductPackagingReadyService : RootService<V_ProductPackagingReady>, IV_ProductPackagingReadyService
    {
        public V_ProductPackagingReadyService(IRepository<V_ProductPackagingReady> repository) : base(repository)
        {
        }
    }
}
