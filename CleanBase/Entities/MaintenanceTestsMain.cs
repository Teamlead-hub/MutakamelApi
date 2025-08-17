using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class MaintenanceTestsMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EntryDate { get; set; }
        public string? AssetsNo { get; set; }
        [NotMapped]
        public string? Asset_Desc { get; set; }
        public string? SubAssetsNo { get; set; }
        [NotMapped]
        public string? SubAssetsNameAr { get; set; }
        [NotMapped]
        public string? SubAssetsNameEn { get; set; }
        public string? AssetsStoreNo { get; set; }
        [NotMapped]
        public string? StoreNameAr { get; set; }
        [NotMapped]
        public string? StoreNameEn { get; set; }

        public string? M_FrequencyNo { get; set; }
        [NotMapped]
        public string? FreqNameAr { get; set; }
        [NotMapped]
        public string? FreqNameEn { get; set; }

        public List<MaintenanceTestsDet> Det { get; set; } = new List<MaintenanceTestsDet>();
    }
}
