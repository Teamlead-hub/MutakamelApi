
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
    public class DeviationMain : EntityRoot
    {

        public string? CatalystId { get; set; }
        public string? DevType { get; set; }
        public string? NonConformityPeriod{ get; set; }
        public string? DescDeviation { get; set; }
        public string? AcceptanceCriteria { get; set; }
        public string? Risk { get; set; }
        public string? Correction { get; set; }
        public string? Investigation { get; set; }
        public string? RootCause { get; set; }
        public string? CorrectiveAction { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? CorrectiveDate { get; set; }
        public string? PreventiveMeasure { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? PreventiveDate { get; set; }
        public int? IsCorrected { get; set; }
        public int? IsAcceptanceCriteria {  get; set; }
        public string ? Notes { get; set; }
    
    } 

}
