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
    public  class V_LcDocsService : RootService<V_LcDocs>, IV_LcDocs
    {
        public V_LcDocsService(IRepository<V_LcDocs> repository) : base(repository) { }
    }
}
