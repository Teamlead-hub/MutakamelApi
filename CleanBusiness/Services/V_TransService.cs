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
    public class V_TransService : RootService<V_Trans>,IV_Trans
    {
        public V_TransService(IRepository<V_Trans> repository) : base(repository)
        { }
    }
}
