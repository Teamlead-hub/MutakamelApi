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
    public class V_AssetsTransferService : RootService<V_AssetsTransfer>, IV_AssetsTransfer
    {
        public V_AssetsTransferService(IRepository<V_AssetsTransfer> repository) : base(repository)
        { }
    }
}
