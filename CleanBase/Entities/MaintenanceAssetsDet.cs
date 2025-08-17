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
    public class MaintenanceAssetsDet :EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? SubAssetsNo { get; set; }
        [NotMapped]
        public string? SubAssetsNameAr { get; set; }
        [NotMapped]
        public string? SubAssetsNameEn { get; set; }
        public string? MaintennanceTypeNo { get; set; }
        [NotMapped]
        public string? TypeNameAR { get; set; }
        [NotMapped]
        public string? TypeNameEn { get; set; }
        public string? MaintenanceFrequencyNo { get; set; }
        [NotMapped]
        public string? FreqNameAr { get; set; }
        [NotMapped]
        public string? FreqNameEn { get; set; }
        public int? IsWarranty { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? WarrentyDate { get; set; }
        public string? Duration { get; set; }
        public string? MaintenanceAssetsMainId { get; set; }
        public MaintenanceAssetsMain? MaintenanceAssetsMain { get; set; }
    }
}
