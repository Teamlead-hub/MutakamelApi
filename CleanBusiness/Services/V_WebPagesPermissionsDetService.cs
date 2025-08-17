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
    public class V_WebPagesPermissionsDetService : RootService<V_WebPagesPermissionsDet>, IV_WebPagesPermissionsDet
    {
        public V_WebPagesPermissionsDetService(IRepository<V_WebPagesPermissionsDet> repository) : base(repository)
        {
        }
    }
}
