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
    public class V_StockSupplierService : RootService<V_StockSupplier>, IV_StockSupplierService
    {
        public V_StockSupplierService(IRepository<V_StockSupplier> repository) : base(repository)
        { }
    }
}
