using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Accounts : EntityRoot
    {
        public string? Accounts_Name { get; set; }
        public string? Accounts_EngName { get; set; }
        public string? Accounts_AcGroupId { get; set; }
        public string? AcGroups_Name { get; set; }
        public decimal? bbf_balance { get; set; }
        public decimal? Debit_Posted { get; set; }
        public decimal? Credit_Posted { get; set; }
        public decimal? amount_Posted { get; set; }
        public decimal? Debit_Not_Posted { get; set; }
        public decimal? Credit_Not_Posted { get; set; }
        public decimal? amount_Not_Posted { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Year_Amount { get; set; }
        public decimal? Current_Balance { get; set; }



    }
}
