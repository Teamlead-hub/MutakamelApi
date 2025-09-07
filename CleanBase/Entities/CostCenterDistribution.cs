
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
    public class CostCenterDistribution : EntityRoot
    {

        public string? CostCenterElementsId { get; set; }
        public List<CostCenterDistributionDet> CostCenterDistributionDet { get; set; } = new List<CostCenterDistributionDet>();

    }

}
