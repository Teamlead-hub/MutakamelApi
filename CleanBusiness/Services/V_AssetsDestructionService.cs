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
    public class V_AssetsDestructionService : RootService<V_AssetsDestruction>, IV_AssetsDestruction
    {
        public V_AssetsDestructionService(IRepository<V_AssetsDestruction> repository) : base(repository)
        { }
    }
}
