using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_ActiveProductionEmployees : EntityRoot
    {
        public string? EmployeeName { get; set; }
        public string? DeptNo { get; set; }
        public string? DeptNameAr { get; set; }
        public string? SectionNo { get; set; }
        public string? SectionName { get; set; }
        public string? JobNo { get; set; }
        public string? JobName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartWorkDate { get; set; }
    }
}
