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
    public class V_SupContractInfoService : RootService<V_SupContractInfo>, IV_SupContractInfo
    {
        public V_SupContractInfoService(IRepository<V_SupContractInfo> repository) : base(repository)
        {
        }

    }
}
