
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
    public class SafetyAccidental : EntityRoot
    {
        public string? ProductName { get; set; }
        public string? SafetyType { get; set; }
        public string? PersonalPrecautions { get; set; }
        public string? ProtectiveEquipment { get; set; }
        public string? EmergencyProcedures { get; set; }
        public string? EnvironmentalPrecautions { get; set; }
        public string? CleanupMethods { get; set; }

    }

}
