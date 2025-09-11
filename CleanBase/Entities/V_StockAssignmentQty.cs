
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
    public class V_StockAssignmentQty : EntityRoot
    {



        public string? StockId { get; set; }
        public string? StoreNo { get; set; }
        public decimal? Qty { get; set; }
       

    } 

}
