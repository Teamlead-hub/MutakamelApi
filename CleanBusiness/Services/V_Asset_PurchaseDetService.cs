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
    public class V_Asset_PurchaseDetService : RootService<V_Asset_PurchaseDet>, IV_Asset_PurchaseDet
    {
        public V_Asset_PurchaseDetService(IRepository<V_Asset_PurchaseDet> repository) : base(repository)
        { }
    }
}
