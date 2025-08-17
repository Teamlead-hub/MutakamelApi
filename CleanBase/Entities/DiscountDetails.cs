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
    public class DiscountDetails : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        [NotMapped]
        public decimal? BasicSal { get; set; }
        
        public string? DiscTypeId { get; set; }
        [NotMapped]
        public string? DiscDescription { get; set; }
        
        public decimal? NoOfHour { get; set; }
        public int? NoofDays { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalAmount { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DescDate { get; set; }
        public string? DiscountMainId { get; set; }
        public DiscountMain? DiscountMain { get; set; }
    }
}
