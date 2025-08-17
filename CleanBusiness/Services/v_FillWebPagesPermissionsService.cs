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
    public class v_FillWebPagesPermissionsService : RootService<v_FillWebPagesPermissions>, Iv_FillWebPagesPermissions
    {
        public v_FillWebPagesPermissionsService(IRepository<v_FillWebPagesPermissions> repository) : base(repository)
        {
        }
    }
}
