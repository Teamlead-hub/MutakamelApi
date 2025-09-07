
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
    public class CostCenterElements : EntityRoot
    {



        public string? CostCenterElement { get; set; }
        public string? CostCenterElementEn { get; set; }
    } 

}
