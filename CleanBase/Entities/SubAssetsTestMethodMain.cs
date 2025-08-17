
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class SubAssetsTestMethodMain : EntityRoot
    {
        public string? MaintenanceTestMethodMainId { get; set; }
        [NotMapped]
        public string? TestNameAr { get; set; }

        [NotMapped]
        public string? TestNameEn { get; set; }

        public string? SubAssetsId { get; set; }
        public SubAssets? SubAssets { get; set; }
        public List<SubAssetsTestMethodSub> SubAssetsTestMethodSub { get; set; }=new List<SubAssetsTestMethodSub>();
    }
}
