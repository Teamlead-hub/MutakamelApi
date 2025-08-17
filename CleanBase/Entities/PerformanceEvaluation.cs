using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PerformanceEvaluation :EntityRoot
    {
        public string TheYears { get; set; }
        public string EmployeesId { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EvaluationDate { get; set; }

        public List<PerformanceEvaluationDet> Det { get; set; } = new List<PerformanceEvaluationDet>();
    }
}
