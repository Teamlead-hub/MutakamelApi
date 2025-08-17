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
    public class V_AssetDepreciationService : RootService<V_AssetDepreciation>, IV_AssetDepreciation
    {
        public V_AssetDepreciationService(IRepository<V_AssetDepreciation> repository) : base(repository)
        {
        }
    }
}
