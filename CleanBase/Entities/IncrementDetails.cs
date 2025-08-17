using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class IncrementDetails : EntityRoot
    {
        
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public decimal? BasicSal { get; set; }
        public decimal? IncrementSal { get; set; }
        public string? AllowanceId { get; set; }
        [NotMapped]
        public string? AllowName { get; set; }
        public decimal? IncrementAllow { get; set; }

        public decimal? AllowanceValue { get; set; }
        public string? IncrementMainId { get; set; }
        public IncrementMain? IncrementMain { get; set; }
    }
}
