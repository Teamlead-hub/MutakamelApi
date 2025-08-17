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
    public class V_PerformanceEvaluationDetService : RootService<V_PerformanceEvaluationDet>, IV_PerformanceEvaluationDet
    {
        public V_PerformanceEvaluationDetService(IRepository<V_PerformanceEvaluationDet> repository) : base(repository)
        {
        }
    }
}
