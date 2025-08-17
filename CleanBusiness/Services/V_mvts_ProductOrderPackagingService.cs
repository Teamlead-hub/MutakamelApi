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
    public class V_mvts_ProductOrderPackagingService : RootService<V_mvts_ProductOrderPackaging>, IV_mvts_ProductOrderPackagingService
    {
        public V_mvts_ProductOrderPackagingService(IRepository<V_mvts_ProductOrderPackaging> repository) : base(repository)
        { }
    }
}
