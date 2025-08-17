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
    public class V_WebMenuUserService : RootService<V_WebMenuUser>, IV_WebMenuUserService
    {
        public V_WebMenuUserService(IRepository<V_WebMenuUser> repository) : base(repository)
        { }
    }
}
