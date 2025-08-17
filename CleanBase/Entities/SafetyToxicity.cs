
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
    public class SafetyToxicity : EntityRoot
    {
   
       public string? ProductName { get; set; }
       public string? SafetyType { get; set; }
       public string?AcuteToxicity{ get; set; }
       public string?Irritation{ get; set; }
       public string?Sensitivity{ get; set; }
       public string?GeneticMutations{ get; set; }
       public string?Carcinogenicity{ get; set; }
       public string?Congenital{ get; set; }
       public string?InhalationRisk{ get; set; }
       public string?General{ get; set; }
       public string?Cancer{ get; set; }
       public string?GeneticMutations1{ get; set; }
       public string?Ingestion{ get; set; }
       public string?EyeContact{ get; set; }
       public string?Inhalation{ get; set; }
       public string?SkinContact{ get; set; }
       public string?Ingestion1{ get; set; }
       public string?EyeContact2{ get; set; }
       public string?Inhalation2{ get; set; }
       public string?SkinContact2{ get; set; }
       public string?Ingestion2{ get; set; }




    }

}
