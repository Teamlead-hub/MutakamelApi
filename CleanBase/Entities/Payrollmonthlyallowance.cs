using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Payrollmonthlyallowance : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int Mvno { get; set; }
        public string? EmployeeNo { get; set; }
        public string? AllowanceId { get; set; }
        [NotMapped]
        public string? AllowName { get; set; }
        
        public decimal? AllowanceValue { get; set; }
        public string? TheYear { get; set; }
        public int? TheMonth { get; set; }   
        public int? PayRollMonthlyId { get; set; }
        public PayRollMonthly? PayRollMonthly { get; set; }

    }
}
