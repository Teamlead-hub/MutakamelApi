using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class WeeklyPlanDetEmployees : EntityRoot
    {
        public string? WeeklyPlanDetId { get; set; }
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public WeeklyPlanDet? WeeklyPlanDet { get; set; }
    }
}
