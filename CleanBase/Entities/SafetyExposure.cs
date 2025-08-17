
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
    public class SafetyExposure : EntityRoot
    {
        public string? ProductName { get; set; }
        public string? SafetyType { get; set; }
       public string?StaffTraining{ get; set; }
      public string?SafeWorkProcedures{ get; set; }
      public string?ExposureMonitoring{ get; set; }
      public string?Ventilation{ get; set; }
      public string?Insulation{ get; set; }
      public string?Automation{ get; set; }
      public string?MaintenanceEquipment{ get; set; }
      public string?Respirators{ get; set; }
      public string?HandProtection{ get; set; }
      public string?BodyProtection{ get; set; }
      public string?ProtectEyes{ get; set; }

    }

}
