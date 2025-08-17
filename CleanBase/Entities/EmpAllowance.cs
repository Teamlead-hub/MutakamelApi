using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class EmpAllowance : EntityRoot
    {
        
      
        [NotMapped]
        public string? EmployeeName { get; set; }
        [NotMapped]
        public decimal? BasicSal { get; set; }
        public string? Allowanceid { get; set; }
        [NotMapped]
        public string? AllowName { get; set; }
        public decimal? AllowanceValue { get; set; }

        public string? EmployeeId { get; set; }
        public Employees? Employees { get; set; }
    }
}
