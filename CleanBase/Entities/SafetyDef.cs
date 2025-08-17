
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
    public class SafetyDef : EntityRoot
    {
      public string? ProductName { get; set; }
      public string? SafetyType { get; set; }
  
      [JsonConverter(typeof(DateOnlyJsonConverter))]
      public DateOnly?ReviewDate{ get; set; }
      public string?ToUse{ get; set; }
      public string?NotToUse{ get; set; }
      public string?SupplierId{ get; set; }
      public string? SupplierName { get; set; }
      public decimal? TelNumber { get; set; }
      public string? Address { get; set; }
     


    } 

}
