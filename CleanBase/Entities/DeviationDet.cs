
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
    public class DeviationDet : EntityRoot
    {
        public string? DeviationMainId { get; set; }

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
        public string? DepartmentManager { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? DepDate { get; set; }
        public string? QualityControl { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? QualityControlDate { get; set; }
        public string? Pharmacist { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? PharmacistDate { get; set; }

        public DeviationMain? DeviationMain { get; set; }
    } 

}
 
     
   
    