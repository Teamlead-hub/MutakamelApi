
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
    public class ProductWithdrawal : EntityRoot
    {

        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? BatchNo { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? MDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? WDate { get; set; }
        public decimal? Qty { get; set; }
        public string? WithdrawalName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? WithdrawalDate { get; set; }
        public string? ProceduresFollowed { get; set; }
        public int? IsStopped { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? StoppedDate { get; set; }
        [JsonConverter(typeof(TimeOnlyJsonConverter))]

        public TimeOnly? StoppedTime { get; set; }

    }

}

