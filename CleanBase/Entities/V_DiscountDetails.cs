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
    public class V_DiscountDetails : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }

        public decimal? BasicSal { get; set; }
        public string? DiscTypeId { get; set; }
      
        public string? DiscDescription { get; set; }
        public decimal? NoOfHour { get; set; }
        public int? NoofDays { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalAmount { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DescDate { get; set; }
        public string? DiscountMainId { get; set; }
        public V_DiscountMain? DiscountMain { get; set; }
    }
}
