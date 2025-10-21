using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class LeadsAndDeals : EntityRoot
    {
        public string? CustomerId { get; set; }
        public string? LeadId { get; set; }
        [NotMapped]
        public string? CustomerName { get; set; }
        [NotMapped]
        public int? CustomerTaxable { get; set; }
        [NotMapped]
        public decimal? CustomerDisc { get; set; }
        [NotMapped]
        public int? CustomerDiscType { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set; }
        public decimal? Total { get; set; }
        public string? SourceId { get; set; }
        [NotMapped]
        public string? SourceName { get; set; }
        public string? Labels { get; set; }
        [NotMapped]
        public string? LabelsName { get; set; }
        [NotMapped]
        public string? LabelsColor { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? CloseDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DeliveryDate { get; set; }

        public int? ClosedDealFlag { get; set; }
        public int? ConvertToDealFlag { get; set; }
        public string? WebPagesUsersId { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string? notes { get; set; }
        [NotMapped]
        public string? WebPagesUserName { get; set; }
        public List<LeadDealProducts> LeadDealProducts {  get; set; }=new List<LeadDealProducts>();
        public List<LeadDealActivity> LeadDealActivity {  get; set; }=new List<LeadDealActivity>();
    }
}
