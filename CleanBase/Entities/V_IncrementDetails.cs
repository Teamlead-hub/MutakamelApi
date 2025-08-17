using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_IncrementDetails:EntityRoot
    {
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public decimal? BasicSal { get; set; }
        public decimal? IncrementSal { get; set; }
        public string? AllowanceId { get; set; }
        public string? AllowName { get; set; }
        public decimal? IncrementAllow { get; set; }

        public decimal? AllowanceValue { get; set; }
        
        public string? IncrementMainId { get; set; }
        public V_IncrementMain? IncrementMain { get; set; }

    }
}
