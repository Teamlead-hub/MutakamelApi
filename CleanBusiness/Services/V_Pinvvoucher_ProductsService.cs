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
    public class V_Pinvvoucher_ProductsService : RootService<V_Pinvvoucher_Products>, IV_Pinvvoucher_ProductsService
    {
        public V_Pinvvoucher_ProductsService(IRepository<V_Pinvvoucher_Products> repository) : base(repository)
        { }
    }
}
