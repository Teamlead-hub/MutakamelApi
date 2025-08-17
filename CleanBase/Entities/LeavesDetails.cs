using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class LeavesDetails : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? LeaveDate { get; set; }
        public string? FromHour { get; set; }
        public string? ToHour { get; set; }
        public decimal? HourCounts { get; set; }
        public decimal? TempHour { get; set; }
        public string? Notes { get; set; }
        public int? ComputeFlag { get; set; }
        public decimal? NoofPostingDay { get; set; }
        public int? IsPost { get; set; }
        public string? Theyear { get; set; }
        public string? LeavesMainId { get; set; }
        public LeavesMain? LeavesMain { get; set; }
    }
}
