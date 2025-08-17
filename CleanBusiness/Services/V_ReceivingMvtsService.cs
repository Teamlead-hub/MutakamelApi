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
    public class V_ReceivingMvtsService : RootService<V_ReceivingMvts>, IV_ReceivingMvts
    {
        public V_ReceivingMvtsService(IRepository<V_ReceivingMvts> repository) : base(repository)
        { }
    }
}
