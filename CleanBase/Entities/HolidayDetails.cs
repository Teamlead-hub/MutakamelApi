using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class HolidayDetails : EntityRoot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public string? HolidayType { get; set; }
        [NotMapped]
        public string? HolidayTypeDesc { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? FromDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ToDate { get; set; }
        public decimal? DayCounts { get; set; }
        public string? Notes { get; set; }
        public string? TheYear { get; set; }
        public string? HolidayMainId { get; set; }
        public HolidayMain? HolidayMain { get; set; }
    }
}
