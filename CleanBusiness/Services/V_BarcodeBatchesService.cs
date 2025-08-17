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
    public class V_BarcodeBatchesService : RootService<V_BarcodeBatches>, IV_BarcodeBatches
    {
        public V_BarcodeBatchesService(IRepository<V_BarcodeBatches> repository) : base(repository)
        {
        }

    }
}
