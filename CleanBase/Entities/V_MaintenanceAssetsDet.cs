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
    public class V_MaintenanceAssetsDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? SubAssetsNo { get; set; }
        public string? SubAssetsNameAr { get; set; }
        public string? SubAssetsNameEn { get; set; }
        public string? MaintennanceTypeNo { get; set; }
        public string? TypeNameAR { get; set; }
        public string? TypeNameEn { get; set; }
        public string? MaintenanceFrequencyNo { get; set; }
        public string? FreqNameAr { get; set; }
        public string? FreqNameEn { get; set; }
        public int? IsWarranty { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? WarrentyDate { get; set; }
        public string? Duration { get; set; }
        public string? MaintenanceAssetsMainId { get; set; }
        public V_MaintenanceAssetsMain? MaintenanceAssetsMain { get; set; }
    }
}
