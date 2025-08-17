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
    public class V_PerformanceEvaluationService : RootService<V_PerformanceEvaluation>, IV_PerformanceEvaluation
    {
        public V_PerformanceEvaluationService(IRepository<V_PerformanceEvaluation> repository) : base(repository)
        {
        }
    }
}
