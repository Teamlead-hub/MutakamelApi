
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
    public class SafetyPhysical : EntityRoot
    {
   
      public string? ProductName { get; set; }
        public string? SafetyType { get; set; }

    
     public string ?PhysicalCondition{ get; set; }
     public string ?Color{ get; set; }
     public string ?Smell{ get; set; }
     public string ?OdorThreshold{ get; set; }
     public string ?MeltingPoint{ get; set; }
     public string ?FreezingPoint{ get; set; }
     public string ?BoilingPoint{ get; set; }
     public string ?Flammable{ get; set; }
     public string ?AutoIgnitionTemperature{ get; set; }
     public string ?FlashPoint{ get; set; }
     public string ?RiskOfExplosion{ get; set; }
     public string ?ExplosionLimits{ get; set; }
     public string ?PH{ get; set; }
     public string ?VaporPressure{ get; set; }
     public string ?RelativeDensity{ get; set; }
     public string ?RelativeDensityOfSteam{ get; set; }
     public string ?EvaporationRate{ get; set; }
     public string ?Viscosity{ get; set; }
     public string ?Dynamic{ get; set; }
     public string ?SolubilityInWater{ get; set; }
     public string ?DecompositionTemperature{ get; set; }


    }

}

      