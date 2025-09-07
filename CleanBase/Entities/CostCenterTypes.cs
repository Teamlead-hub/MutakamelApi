
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
    public class CostCenterTypes : EntityRoot
    {



        public string? CostCenterType { get; set; }

        public string? CostCenterTypeEn { get; set; }

    }

}
