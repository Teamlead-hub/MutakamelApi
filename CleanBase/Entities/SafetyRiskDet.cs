
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
    public class SafetyRiskDet : EntityRoot
    {

         public string?SafetyRiskId { get; set; }
         public string?RiskGroupName { get; set; }
         public string?RiskCategoryName { get; set; }
         public string?RiskDescName { get; set; }
        public SafetyRisk? SafetyRisk { get; set; }

    } 

}
