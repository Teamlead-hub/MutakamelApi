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
    public class V_AssetsService : RootService<V_Assets>, IV_Assets
    {
        public V_AssetsService(IRepository<V_Assets> repository) : base(repository)
        { }
    }
}
