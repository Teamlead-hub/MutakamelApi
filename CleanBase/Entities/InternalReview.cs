using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class InternalReview : EntityRoot
    {
        public string? ReviewScope { get; set; }
        public string? ReviewGoal { get; set; }
        public string? ReviewCriteria { get; set; }
        public string? ReviewTeam { get; set; }
        public string? DataCollectionMethods { get; set; }
        public string? DataAnalysisMethods { get; set; }
        public string? RisksAndOpportunities { get; set; }
        public string? ReviewResults { get; set; }
        public string? RecommendForPerformance { get; set; }
    } 
}
