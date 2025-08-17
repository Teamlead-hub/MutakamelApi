using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class HolidayMain : EntityRoot
    {
        
        public string EmployeeNo { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        public string TheYear { get; set; }
        public decimal? DueAnnual { get; set; }
        public decimal? AnnualBalance { get; set; }
        public decimal? AnnualUsedBalance { get; set; }
        public decimal? AnnualRestBalance { get; set; }
        public decimal? DueSick { get; set; }
        public decimal? SickBalance { get; set; }
        public decimal? SickUsedBalance { get; set; }
        public decimal? SickRestBalance { get; set; }
        public decimal? RoundAnnualBalance { get; set; }
        public decimal? HolidayToDate { get; set; }
        public string? Notes { get; set; }
        public List<HolidayDetails> Det { get; set; } = new List<HolidayDetails>();

    }
}
