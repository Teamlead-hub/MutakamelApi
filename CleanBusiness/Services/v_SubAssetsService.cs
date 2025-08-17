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
    public class V_SubAssetsService : RootService<V_SubAssets>, IV_SubAssets
    {
        public V_SubAssetsService(IRepository<V_SubAssets> repository) : base(repository)
        {
        }
    }
}
