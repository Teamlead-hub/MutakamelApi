using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PerformanceEvaluationDet:EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EvaluationElementsNo { get; set; }
        [NotMapped]
        public string? ElementsNameAr { get; set; }
        [NotMapped]
        public string? ElementsNameEn { get; set; }
        public string? EvaluationMarksNo { get; set; }
        [NotMapped]
        public string? MarksNameAr { get; set; }
        [NotMapped]
        public string? MarksNameEn { get; set; }
        public string? PerformanceEvaluationId { get; set; }
        public PerformanceEvaluation? PerformanceEvaluation { get; set; }

    }
}
