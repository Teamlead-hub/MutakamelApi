
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
    public class CostCenterDistributionDet : EntityRoot
    {

        public string? CostCenterId { get; set; }
        public string? CostCenterName { get; set; }

        public decimal? Perc { get; set; }
        public string ? CostCenterDistributionId { get; set; }
        public CostCenterDistribution? CostCenterDistribution { get; set; }

    }

}
