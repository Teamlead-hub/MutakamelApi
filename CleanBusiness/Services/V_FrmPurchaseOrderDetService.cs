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
    public class V_FrmPurchaseOrderDetService : RootService<V_FrmPurchaseOrderDet>, IV_FrmPurchaseOrderDet
    {
        public V_FrmPurchaseOrderDetService(IRepository<V_FrmPurchaseOrderDet> repository) : base(repository)
        {
        }

    }
}