using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_LeadsAndDeals : EntityRoot
    {
        public string? CustomerId { get; set; }
        public string? LeadId { get; set; }
        public string? CustomerName { get; set; }
        public int? CustomerTaxable { get; set; }
        public decimal? CustomerDisc { get; set; }
        public int? CustomerDiscType { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set; }
        public decimal? Total { get; set; }
        public string? SourceId { get; set; }
        public string? SourceName { get; set; }
        public string? Labels { get; set; }
        public string? LabelsName { get; set; }
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
        public string? WebPagesUserName { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string? notes { get; set; }
        public List<V_LeadDealProducts> LeadDealProducts { get; set; } = new List<V_LeadDealProducts>();
        public List<V_LeadDealActivity> LeadDealActivity { get; set; } = new List<V_LeadDealActivity>();
    }
}
