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
    public class V_ProductPackagingService : RootService<V_ProductPackaging>, IV_ProductPackagingService
    {
        public V_ProductPackagingService(IRepository<V_ProductPackaging> repository):base(repository) { }
    }
}
