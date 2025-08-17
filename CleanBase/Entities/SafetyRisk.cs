
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
    public class SafetyRisk : EntityRoot
    {
   
      public string? ProductName { get; set; }
        public string? SafetyType { get; set; }

        public string? RiskStatements { get; set; }
      public string? PreventiveMeasures { get; set; }
       public int? IsRisk { get; set; }
      public string? RiskImages { get; set; }
        public List<SafetyRiskDet> SafetyRiskDet { get; set; } = new List<SafetyRiskDet>();




    }

}
