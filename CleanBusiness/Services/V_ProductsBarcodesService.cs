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
    public class V_ProductsBarcodesService : RootService<V_ProductsBarcodes>, IV_ProductsBarcodesService
    {
        public V_ProductsBarcodesService(IRepository<V_ProductsBarcodes> repository):base(repository) { }
    }
}
