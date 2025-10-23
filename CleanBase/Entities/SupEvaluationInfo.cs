
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
    public class SupEvaluationInfo : EntityRoot
    {

        public string? EvaluationName { get; set; }

        public string? SupplierInfoId { get; set; }

        public string? InvVoucherId { get; set; }


        [NotMapped]
        public string? VchrType { get; set; }

        [NotMapped]
        public string? VchrTypeAr { get; set; }

        [NotMapped]
        public string? VchrTypeEn { get; set; }

        public int? EvaluationRate { get; set; }


        [NotMapped]
        public DateOnly? VchrDate { get; set; }

        public SupplierInfo? SupplierInfo { get; set; } 

    }

}
