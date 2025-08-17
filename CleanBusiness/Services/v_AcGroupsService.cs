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
    public class v_AcGroupsService : RootService<v_AcGroups>, Iv_AcGroups
    {
        public v_AcGroupsService(IRepository<v_AcGroups> repository) : base(repository)
        { }
    }
}
