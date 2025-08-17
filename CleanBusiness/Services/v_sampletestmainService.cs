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
    public class v_sampletestmainService : RootService<v_sampletestmain>, Iv_sampletestmain
    {
        public v_sampletestmainService(IRepository<v_sampletestmain> repository) : base(repository)
        {
        }

    }
}
