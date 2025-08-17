using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class WeeklyPlanDet : EntityRoot
    {
        public string? day { get; set; }
        public string? ProductOrderId { get; set; }
        public string? FromHours { get; set; }
        public string? ToHours { get; set; }
        [NotMapped]
        public string? ProductName { get; set; }
        [NotMapped]
        public string? ProductLineName { get; set; }
        [NotMapped]
        public decimal? Weight { get; set; }
        public string? WeeklyPlanMainId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? date { get; set; }
        public WeeklyPlanMain? WeeklyPlanMain { get; set; }
    }
}
