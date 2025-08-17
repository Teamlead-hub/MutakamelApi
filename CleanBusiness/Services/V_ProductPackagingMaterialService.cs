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
    public class V_ProductPackagingMaterialService : RootService<V_ProductPackagingMaterial>, IV_ProductPackagingMaterialService
    {
        public V_ProductPackagingMaterialService(IRepository<V_ProductPackagingMaterial> repository) : base(repository)
        {
        }

    }
}
