
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
    public class QuarantineMain : EntityRoot
    {

        public string? ReceivingNo { get; set; }
        public decimal? VchrTAX { get; set; }
    public decimal? VchrTotal { get; set; }
        public decimal? VchrSubTotal { get; set; }
        public decimal?  VchrDisc { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public List<QuarantineDet> QuarantineDet { get; set; } = new List<QuarantineDet>();

    }

}
