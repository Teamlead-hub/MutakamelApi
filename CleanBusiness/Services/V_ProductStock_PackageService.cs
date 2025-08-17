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
    public class V_ProductStock_PackageService:RootService<V_ProductStock_Package>, IV_ProductStock_PackageService
    {
      public V_ProductStock_PackageService(IRepository<V_ProductStock_Package> repository):base(repository) 
        { }
    }
}
