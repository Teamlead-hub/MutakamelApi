using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CleanBase.Entities
{
    public class LeadDealActivity : EntityRoot
    {
        public string? activityTtpe { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? activityDate { get; set; }
        public string? fromTime { get; set; }
        public string? toTime { get; set; }
        public string? notes { get; set; }
        public string? activityTitle { get; set; }
        public int? isDoneFlag { get; set; }
        public string? priority { get; set; }
        public string? LeadsAndDealsId { get; set; }

        public LeadsAndDeals? LeadsAndDeals { get; set; }
    }
}
