using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_EmpAllowance : EntityRoot
    {

   
        public string? EmployeeName { get; set; }
        public decimal? BasicSal { get; set; }
        public string? Allowanceid { get; set; }
        public string? AllowName { get; set; }
        public decimal? AllowanceValue { get; set; }

        public string? EmployeeId { get; set; }
        public V_Employees? Employees { get; set; }

    }
}
