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
    public class V_Asset_PurchaseService : RootService<V_Asset_Purchase>, IV_Asset_Purchase
    {
        public V_Asset_PurchaseService(IRepository<V_Asset_Purchase> repository) : base(repository)
        { }
    }
}
