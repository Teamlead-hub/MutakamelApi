using CleanBase;
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
    public class v_WebPagesPermissionsService : RootService<v_WebPagesPermissions>, Iv_WebPagesPermissions
    {
        public v_WebPagesPermissionsService(IRepository<v_WebPagesPermissions> repository) : base(repository)
        {
        }
    }
}
