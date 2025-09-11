using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class CashBudgetItems : EntityRoot
    {
        public string? BudgetType { get; set; }

        public string? ItemCode { get; set; }

        public string? ItemName { get; set; }

        public string? DefaultCategory { get; set; }

        public bool IsActive { get; set; }
    }
}
