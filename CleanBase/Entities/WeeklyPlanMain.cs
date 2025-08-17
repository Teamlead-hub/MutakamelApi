
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class WeeklyPlanMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? WeekStart { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? WeekEnd { get; set; }

        public List<WeeklyPlanDet> WeeklyPlanDet { get; set; }=new List<WeeklyPlanDet>();
    }
}
