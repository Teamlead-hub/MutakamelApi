using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaintenanceReports:EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int RepId { get; set; }
        public string? MaintenanceTestRepNo { get; set; }
        public string? MaintenanceRequestNo { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? FaultStartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? TestCompletedDate { get; set; }
        public string? AssestNo { get; set; }
        public string? Asset_Desc { get; set; }
        public string? AssestCatgNo { get; set; }
        public string? AsstCatName { get; set; }
        public string? AssetsStoreNo { get; set; }
        public string? StoreName { get; set; }
        public string? StoreNameEn { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? FaultsOccurredDate { get; set; }
        public string? FaultsSymptoms { get; set; }
        public string? RootCauses { get; set; }
        public string? CorrectiveActions { get; set; }
        public string? RepairResult { get; set; }
        public decimal? SubAssestCost { get; set; }
        public decimal? EmployeeCost { get; set; }
        public decimal? TotalCost { get; set; }
        public string? Recommendations { get; set; }
        public string? Notes { get; set; }

    }
}
