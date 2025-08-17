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
    public class V_FillAssetDepService : RootService<V_FillAssetDep>, IV_FillAssetDep
    {
        public V_FillAssetDepService(IRepository<V_FillAssetDep> repository) : base(repository)
        { }
    }
}
