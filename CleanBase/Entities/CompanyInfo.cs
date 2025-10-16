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
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? SalesTaxNo { get; set; }
        public string? City { get; set; }
        public decimal? TotalMonthlyHours { get; set; }
        

    }
}
