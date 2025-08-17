using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class CompanyInfo:EntityRoot
    {
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public decimal? TotalMonthlyHours { get; set; }
        

    }
}
