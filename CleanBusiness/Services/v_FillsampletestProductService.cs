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
    public class v_FillsampletestProductService : RootService<v_FillsampletestProduct>, Iv_FillsampletestProduct
    {
        public v_FillsampletestProductService(IRepository<v_FillsampletestProduct> repository) : base(repository)
        {
        }

    }
}
