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
    public class V_CompanyInfoService : RootService<V_CompanyInfo>, IV_CompanyInfo
    {
        public V_CompanyInfoService(IRepository<V_CompanyInfo> repository) : base(repository)
        {
        }
    }
}
