using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_WeeklyPlanDet : EntityRoot
    {
        public string? day { get; set; }
        public string? ProductOrderId { get; set; }
        public string? FromHours { get; set; }
        public string? ToHours { get; set; }
        public string? ProductName { get; set; }
        public string? ProductLineName { get; set; }
        public decimal? Weight { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? date { get; set; }
        public string? WeeklyPlanMainId { get; set; }
        public V_WeeklyPlanMain? WeeklyPlanMain { get; set; }
    }
}
