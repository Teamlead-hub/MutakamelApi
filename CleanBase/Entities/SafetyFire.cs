
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
    public class SafetyFire : EntityRoot
    {
   
      public string? ProductName { get; set; }
        public string? SafetyType { get; set; }

        public string? CorrectFire { get; set; }
      public string? IncorrectFire { get; set; }
        public string? EmergingRisks { get; set; }
        public string? TipsForFirefighters { get; set; }



    }

}

      