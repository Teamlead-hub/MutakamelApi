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
    public class V_ProductLineService : RootService<V_ProductLine>, IV_ProductLineService
    {
        public V_ProductLineService(IRepository<V_ProductLine> repository) : base(repository)
        { }
    }
}
