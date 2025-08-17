
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
    public class SafetyChemical : EntityRoot
    {
   
          public string? ProductName { get; set; }
          public string? SafetyType { get; set; }
          public string?Interactive{ get; set; }
          public string?ChemicalStability{ get; set; }
          public string?ThermalDisintegration{ get; set; }
          public string?Potential{ get; set; }
          public string?Conditions{ get; set; }
          public string?Incompatible{ get; set; }
          public string?Hazardous{ get; set; }


    }

}
