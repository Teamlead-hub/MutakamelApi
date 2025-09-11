using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ContractItems : EntityRoot 
    {

        public string ContractsId { get; set; }
        public Contracts? Contracts { get; set; }
        public string Description { get; set; }

        public decimal Amount { get; set; }
        public string CostCenterID { get; set; }

        public decimal AllocationPercent { get; set;}
    }
}
