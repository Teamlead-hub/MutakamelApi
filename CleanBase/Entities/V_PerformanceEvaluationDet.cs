using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_PerformanceEvaluationDet :EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EvaluationElementsNo { get; set; }
        public string? ElementsNameAr { get; set; }
        public string? ElementsNameEn { get; set; }
        public string? EvaluationMarksNo { get; set; }
        public string? MarksNameAr { get; set; }
        public string? MarksNameEn { get; set; }   
        public string? PerformanceEvaluationId { get; set; }
        public V_PerformanceEvaluation? PerformanceEvaluation { get; set; }
    }
}
