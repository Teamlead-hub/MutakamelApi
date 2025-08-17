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
    public class V_ProductOrderPackingMaterialService:RootService<V_ProductOrderPackingMaterial>, IV_ProductOrderPackingMaterialService
    {
        public V_ProductOrderPackingMaterialService(IRepository<V_ProductOrderPackingMaterial> repository) : base(repository) { }  
    }
}
