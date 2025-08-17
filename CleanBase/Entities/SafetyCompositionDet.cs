
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
    public class SafetyCompositionDet : EntityRoot
    {

        public string ? StockId { get; set; }
        public string? ArabicName { get; set; }
        public decimal? PercInProduct { get; set; }
        public decimal? Weight { get; set; }
        public string? RiskGroupName { get; set; }
        public string? RiskCategoryName { get; set; }
        public string? SafetyCompositionId { get; set; }
        public SafetyComposition? SafetyComposition { get; set; }

    }

}
