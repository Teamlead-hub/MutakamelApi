using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_LeavesMain : EntityRoot
    {
        
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? TheYear { get; set; }
        public decimal? NonPostingHour { get; set; }
        public int? NoOfPostingDay { get; set; }

        public List<V_LeavesDetails> Det { get; set; } = new List<V_LeavesDetails>();
    }
}
