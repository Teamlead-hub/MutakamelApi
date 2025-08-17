using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaintenanceTestsMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EntryDate { get; set; }
        public string? AssetsNo { get; set; }
        public string? Asset_Desc { get; set; }
        public string? SubAssetsNo { get; set; }
        public string? SubAssetsNameAr { get; set; }
        public string? SubAssetsNameEn { get; set; }
        public string? AssetsStoreNo { get; set; }
        public string? StoreNameAr { get; set; }
        public string? StoreNameEn { get; set; }
        public string? M_FrequencyNo { get; set; }
        public string? FreqNameAr { get; set; }
        public string? FreqNameEn { get; set; }

        public List<V_MaintenanceTestsDet> Det { get; set; } = new List<V_MaintenanceTestsDet>();

    }
}
