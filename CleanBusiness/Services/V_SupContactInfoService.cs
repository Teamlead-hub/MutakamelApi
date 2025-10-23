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
    public class V_SupContactInfoService : RootService<V_SupContactInfo>, IV_SupContactInfo
    {
        public V_SupContactInfoService(IRepository<V_SupContactInfo> repository) : base(repository)
        {
        }

    }
}
