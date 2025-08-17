
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanBase.Entities;


namespace CleanBase.Entities
{
    public class SupContractInfo : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? ContractDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ReviseDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EndDate { get; set; }
        public string? ContractDuration { get; set; }
        public int? IsCompatible { get; set; }
        public string? ContractNotes { get; set; }
        public string? Discount  { get; set; }
        public string? SupplierInfoId { get; set; }
        public SupplierInfo? SupplierInfo { get; set; }


    }

}
      