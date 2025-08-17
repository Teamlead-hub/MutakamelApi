using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PayRollMonthly : EntityRoot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int Mvno { get; set; }
        public string? EmployeeNo { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public string? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public decimal? BasicSal { get; set; }
        public decimal? TotAllow { get; set; }
        public decimal? OverTime { get; set; }
        [NotMapped]
        public decimal? TotalSalary { get; set; }
        public decimal? SocSec { get; set; }
        public decimal? Health { get; set; }
        public decimal? Tax { get; set; }
        public decimal? loans { get; set; }
        public decimal? TotDiscount { get; set; }
        [NotMapped]
        public decimal? TotalDeduction { get; set; }
        [NotMapped]
        public decimal? NetSalary { get; set; }
        public int? PostSalary { get; set; }
        public string? PayrollMainId { get; set; }
        public PayRollMain? PayRollMain { get; set; }
        public List<Payrollmonthlyallowance> Detallow { get; set; } = new List<Payrollmonthlyallowance>();

        
    }
}
