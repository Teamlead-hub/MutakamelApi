using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaintenanceTestsDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? M_TestMethodMainNo { get; set; }
        public string? TestNameAr { get; set; }
        public string? TestNameEn { get; set; }
        public string? M_TestMethodSubNo { get; set; }
        public string? SubTestNameAr { get; set; }
        public string? SubTestNameEn { get; set; }
        public int? IsTested { get; set; }
        public int? IsFaults { get; set; }
        public string? PrioritiesNo { get; set; }
        public string? PriorityNameAr { get; set; }
        public string? PriorityNameEn { get; set; }
        public string? RepairAgenciesNo { get; set; }
        public string? AgenciesNameAr { get; set; }
        public string? AgenciesNameEn { get; set; }
        public string? MaintenanceTestsMainId { get; set; }
        public string? Notes { get; set; }
        public V_MaintenanceTestsMain? MaintenanceTestsMain { get; set; }
    }
}
