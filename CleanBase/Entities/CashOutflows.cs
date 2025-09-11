using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class CashOutflows : EntityRoot
    {
        public string? BudgetID { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }

        public decimal? ExpectedAmount { get; set; }

        public DateTime ExpectedDate { get; set; }

        public string? BudgetItemID { get; set; }
        public CashBudgetItems? BudgetItem { get; set; }

    }
}
