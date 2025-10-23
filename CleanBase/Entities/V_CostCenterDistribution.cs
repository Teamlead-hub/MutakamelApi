
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
    public class V_CostCenterDistribution : EntityRoot
    {

        public string? CostCenterElementsId { get; set; }
        public string? CostCenterElementsName { get; set; }

        public List<V_CostCenterDistributionDet> CostCenterDistributionDet { get; set; } = new List<V_CostCenterDistributionDet>();

    }

}
