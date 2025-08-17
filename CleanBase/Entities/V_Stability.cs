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
    public class V_Stability : EntityRoot
    {
        public string? ExperimentName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExperimentStratDate { get; set; }
        public string? ResearcherInCharge { get; set; }
        public string? ResearcherName { get; set; }
        public string? LabName { get; set; }
        public string? ProductId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? BatchNo { get; set; }
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
