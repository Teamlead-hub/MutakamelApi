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
    public class V_ProductOrderPackagingService:RootService<V_ProductOrderPackaging>, IV_ProductOrderPackagingService
    {
        public V_ProductOrderPackagingService(IRepository<V_ProductOrderPackaging> repository):base(repository) { }
    }
}
