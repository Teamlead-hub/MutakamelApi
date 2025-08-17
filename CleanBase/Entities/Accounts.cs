
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanBase.Entities
{
    public class Accounts : EntityRoot
    {



        public string? Accounts_Name { get; set; }
        public string? Accounts_EngName { get; set; }
        public string? Accounts_AcGroupId { get; set; }
        [NotMapped]
        public string? AcGroups_Name { get; set; }
        [NotMapped]
        public decimal? bbf_balance { get; set; }
        [NotMapped]
        public decimal? Debit_Posted { get; set; }
        [NotMapped]
        public decimal? Credit_Posted { get; set; }
        [NotMapped]
        public decimal? amount_Posted { get; set; }
        [NotMapped]
        public decimal? Debit_Not_Posted { get; set; }
        [NotMapped]
        public decimal? Credit_Not_Posted { get; set; }
        [NotMapped]
        public decimal? amount_Not_Posted { get; set; }
        [NotMapped]
        public decimal? Debit { get; set; }
        [NotMapped]
        public decimal? Credit { get; set; }
        [NotMapped]
        public decimal? Year_Amount { get; set; }
        [NotMapped]
        public decimal? Current_Balance { get; set; }

    } 

}
