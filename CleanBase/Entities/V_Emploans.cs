using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Emploans : EntityRoot
    {
        public decimal? LoansValue { get; set; }
        public decimal? LoansMonthly { get; set; }
        public decimal? loansDeducts { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDeduct { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? LoansDate { get; set; }
        public string?  EmployeeName { get; set; }

    }
}
