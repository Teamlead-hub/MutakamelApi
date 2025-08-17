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
    public class SuppEvaluationService : RootService<SuppEvaluation>, ISuppEvaluation
    {
        public SuppEvaluationService(IRepository<SuppEvaluation> repository) : base(repository)
        {
        }

    }
}
