
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
    public class SafetyRegulatoy : EntityRoot
    {

     public string ?ProductName{ get; set; }
      public string ?SafetyType{ get; set; }
      public string ?LegislationRelating{ get; set; }
      public string ?LimitsOfUse{ get; set; }
      public string ?ChemicalSafety{ get; set; }
    } 

}
