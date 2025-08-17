using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class LeavesMain : EntityRoot
    {
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public string? TheYear { get; set; }
        public decimal? NonPostingHour { get; set; }
        public int? NoOfPostingDay { get; set; }

        public List<LeavesDetails> Det { get; set; } = new List<LeavesDetails>();
    }
}
