using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaintenanceAssetsMain : EntityRoot
    {
        public string Assetno { get; set; }
        public string Asset_Desc { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly PurchaseDate { get; set; }
        public string ManufactorCompany { get; set; }
        public string Asset_version { get; set; }
        public string AssetStoreNo { get; set; }
        public string StoreNameAr { get; set; }
        public string StoreNameEn { get; set; }

        public List<V_MaintenanceAssetsDet> Det { get; set; } = new List<V_MaintenanceAssetsDet>();
    }
}
