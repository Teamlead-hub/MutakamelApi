
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
    public class V_StockAssignment : EntityRoot
    {



        public string? AssetID { get; set; }
        public string? Asset_Desc { get; set; }
        public string? EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? AssignmentDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? ExpectedReturnDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? ActualReturnDate { get; set; }

        public string? ConditionOnReturn { get; set; }

        public string? Remarks { get; set; }
        public decimal? QtyOut { get; set; }
        public decimal? QtyIn { get; set; }
        public string? StoreId { get; set; }

        public string? StoreName { get; set; }

    }

}
