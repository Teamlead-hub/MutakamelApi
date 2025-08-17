using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class MaintenanceTestsDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? M_TestMethodMainNo { get; set; }
        [NotMapped]
        public string? TestNameAr { get; set; }
        [NotMapped]
        public string? TestNameEn { get; set; }
        public string? M_TestMethodSubNo { get; set; }
        [NotMapped]
        public string? SubTestNameAr { get; set; }
        [NotMapped]
        public string? SubTestNameEn { get; set; }
        public int? IsTested { get; set; }
        public int? IsFaults { get; set; }
        public string? PrioritiesNo { get; set; }
        [NotMapped]
        public string? PriorityNameAr { get; set; }
        [NotMapped]
        public string? PriorityNameEn { get; set; }
        public string? RepairAgenciesNo { get; set; }
        [NotMapped]
        public string? AgenciesNameAr { get; set; }
        [NotMapped]
        public string? AgenciesNameEn { get; set; }
        public string? Notes { get; set; }
        
        public string? MaintenanceTestsMainId { get; set; }
        public MaintenanceTestsMain? MaintenanceTestsMain { get; set; }
    }
}
