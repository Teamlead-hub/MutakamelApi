
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
    public class SafetyComposition : EntityRoot
    {

        public string? ProductName { get; set; }
        public string? SafetyType { get; set; }
        public int? IsMixed { get; set; }
        public List<SafetyCompositionDet> SafetyCompositionDet { get; set; } = new List<SafetyCompositionDet>();


    }

}
