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
    public class V_SubAssetsTestMethodMainService : RootService<V_SubAssetsTestMethodMain>, IV_SubAssetsTestMethodMainService
    {
        public V_SubAssetsTestMethodMainService(IRepository<V_SubAssetsTestMethodMain> repository) : base(repository)
        { }
    }
}
