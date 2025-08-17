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
    public class V_SupEvaluationInfoService : RootService<V_SupEvaluationInfo>, IV_SupEvaluationInfo
    {
        public V_SupEvaluationInfoService(IRepository<V_SupEvaluationInfo> repository) : base(repository)
        {
        }

    }
}
