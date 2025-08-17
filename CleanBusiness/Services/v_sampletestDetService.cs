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
    public class v_sampletestDetService : RootService<v_sampletestDet>, Iv_sampletestDet
    {
        public v_sampletestDetService(IRepository<v_sampletestDet> repository) : base(repository)
        {
        }

    }
}
