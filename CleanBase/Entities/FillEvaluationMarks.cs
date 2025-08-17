using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class FillEvaluationMarks : EntityRoot
    {
        public string? ElementsNameAr { get; set; }
        public string? ElementsNameEn { get; set; }
        public string? GoodMarksId { get; set; }
        public string? GoodMarksAr { get; set; }
        public string? GoodMarksEn { get; set; }
        public string? AverageMarksId { get; set; }
        public string? AverageMarksAr { get; set; }
        public string? AverageMarksEn { get; set; }
        public string? BadMarksId { get; set; }
        public string? BadMarksAr { get; set; }
        public string? BadMarksEn { get; set; }

    }
}
