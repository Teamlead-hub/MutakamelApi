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
    public class Asset_PurchaseService : RootService<Asset_Purchase>, IAsset_Purchase
    {
        public Asset_PurchaseService(IRepository<Asset_Purchase> repository) : base(repository)
        { }
    }
}
