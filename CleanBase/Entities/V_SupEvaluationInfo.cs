
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
    public class V_SupEvaluationInfo : EntityRoot
    {

        public string? EvalutionTypesId { get; set; }
        public string? EvaluationName { get; set; }
        public string? EvaluationNameEn { get; set; }
        public string? SupplierInfoId { get; set; }
        public string? InvVoucherId { get; set; }

        public string? VchrType { get; set; }
        public string? VchrTypeAr { get; set; }
        public string? VchrTypeEn { get; set; }
       
        public int? EvaluationRate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public V_SupplierInfo? SupplierInfo { get; set; }


    }
}
