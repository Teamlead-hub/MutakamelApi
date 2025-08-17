using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanBase.Entities
{
    public class Stability : EntityRoot
    {
        public string? ExperimentName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExperimentStratDate { get; set; }
        public string? ResearcherInCharge { get; set; } 

        [NotMapped]
        public string? ResearcherName { get; set; }

        public string? LabName { get; set; }
        public string? ProductId { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? EnglishName { get; set; }
        public string? BatchNo { get; set; }

        [NotMapped]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ProductionDate { get; set; }

        public string? Temperature { get; set; }
        public string? Humidity { get; set; }
        public string? Light { get; set; }
        public string? TestType { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? TestDate { get; set; }
        public string? TestResult { get; set; }
        public string? Changes { get; set; }
        public string? Conclusions { get; set; }

    }
}
