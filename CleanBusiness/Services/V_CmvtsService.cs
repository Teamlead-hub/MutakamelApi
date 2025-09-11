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
    public class V_CmvtsService : RootService<V_Cmvts>, IV_Cmvts
    {
        public V_CmvtsService(IRepository<V_Cmvts> repository) : base(repository)
        { }
    }
}
