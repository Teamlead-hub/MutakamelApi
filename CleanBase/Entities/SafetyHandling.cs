
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
    public class SafetyHandling : EntityRoot
    {
      public string? ProductName { get; set; }
      public string? SafetyType { get; set; }
      public string? HandlingTheItem { get; set; }
      public string? ExplosionsAndFires { get; set; }
      public string? RequirementsForStorage { get; set; }
      public string? SharedStorage { get; set; }
      public string? AdditionalInformation { get; set; }

    }

}
     