
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
    public class v_FillsampletestProduct : EntityRoot
    {
        public string? Id { get; set; }
        public string? ItemName { get; set; }
        public string? ProductSpecsId { get; set; }
        public string? SpecName { get; set; }
        public string? ProductTestId { get; set; }
       public string? TestName { get; set; }

    } 

}
