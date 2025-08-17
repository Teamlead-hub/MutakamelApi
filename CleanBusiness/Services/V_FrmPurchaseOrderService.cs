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
    public class V_FrmPurchaseOrderService : RootService<V_FrmPurchaseOrder>, IV_FrmPurchaseOrder
    {
        public V_FrmPurchaseOrderService(IRepository<V_FrmPurchaseOrder> repository) : base(repository)
        { }
    }
}
