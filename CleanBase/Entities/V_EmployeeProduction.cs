using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_EmployeeProduction:EntityRoot
    {
        public string? EmployeeName { get; set; }
        public string? DeptNo { get; set; }
        public string? DeptNameAr { get; set; }
        public string? SectionNo { get; set; }
        public string? SectionName { get; set; }
        public string? JobNo { get; set; }
        public string? JobName { get; set; }
        public decimal? HourlyRate { get; set; }
    }
}
