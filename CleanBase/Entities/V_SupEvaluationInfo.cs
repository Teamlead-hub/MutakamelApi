
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

        public string? EvaluationName { get; set; }
        public string? SupplierInfoId { get; set; }
       
        public int? EvaluationRate { get; set; }
        public string? SupEvaluationInfoId { get; set; }
        public SupplierInfo? SupplierInfo { get; set; }

        //public SupEvaluationInfo? SupEvaluationInfo { get; set; }

    }
}
