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
    public class V_SpecificationsService : RootService<V_Specifications>, IV_SpecificationsService
    {
        public V_SpecificationsService(IRepository<V_Specifications> repository) : base(repository)
        { }
    }
}
