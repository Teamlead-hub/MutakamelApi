
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
    public class SafetyTransportation : EntityRoot
    {

      public string ?ProductName{ get; set; }
      public string ?SafetyType{ get; set; }
      public string ?IdentityNo{ get; set; }
      public string ?ShippingName{ get; set; }
      public string ?HazardClass{ get; set; }
      public string ?PackingSet{ get; set; }
      public string ?EnvironmentalRisks{ get; set; }
    } 

}
