using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_OverTimeDetails : EntityRoot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public decimal? NoOfHour { get; set; }
        public int? NoofDays { get; set; }
        public int? Holiday { get; set; }
        public decimal? Reward { get; set; }
        public int? TheMonth { get; set; }
        public int? PostFlag { get; set; }
        public string? OvertimeMainId { get; set; }
        public V_OverTimeMain? OvertimeMain { get; set; }

    }


}
