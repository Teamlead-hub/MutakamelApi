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
    public class Asset_PurchaseDetService : RootService<Asset_PurchaseDet>, IAsset_PurchaseDet
    {
        public Asset_PurchaseDetService(IRepository<Asset_PurchaseDet> repository) : base(repository)
        { }
    }
}
