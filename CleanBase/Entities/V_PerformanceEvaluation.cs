using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_PerformanceEvaluation : EntityRoot
    {
        public string TheYears { get; set; }
        public string EmployeesId { get; set; }
        public string EmployeeName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EvaluationDate { get; set; }

        public List<V_PerformanceEvaluationDet> Det { get; set; } = new List<V_PerformanceEvaluationDet>();

    }
}
