using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_MaintenanceRequestDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? M_FaultsNo { get; set; }
        public string? FaultsNameAr { get; set; }
        public string? FaultsNameEn { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? M_FaultsDate { get; set; }
        public string? M_symptoms { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Repair_StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Repair_EndDate { get; set; }
        public decimal? RepairCost { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public string? Repair_Tools { get; set; }
        public string? MaintenanceRequestMainId { get; set; }
        public V_MaintenanceRequestMain? MaintenanceRequestMain { get; set; }
    }
}
