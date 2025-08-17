
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
    public class RiskCategory : EntityRoot
    {

        public string? RiskCategoryName { get; set; }

        public string?RiskGroupId { get; set; }

        public RiskGroup? RiskGroup { get; set; }
    } 

}
