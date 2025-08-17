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
    public class V_mvtsService : RootService<V_mvts>, IV_mvts
    {
        public V_mvtsService(IRepository<V_mvts> repository) : base(repository)
        { }
    }
}
