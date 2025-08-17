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
    public class V_InvStock_RawService:RootService<V_InvStock_Raw>, IV_InvStock_RawService
    {
        public V_InvStock_RawService (IRepository<V_InvStock_Raw> repository) : base (repository) { }
    }
}
