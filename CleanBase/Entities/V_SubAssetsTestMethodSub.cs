
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class V_SubAssetsTestMethodSub : EntityRoot
    {
        public string? MaintenanceTestMethodSubId { get; set; }
        public string? SubTestNameAr { get; set; }
        public string? SubTestNameEn { get; set; }
        public string? SubAssetsTestMethodMainId { get; set; }
        public V_SubAssetsTestMethodMain? SubAssetsTestMethodMain { get; set; }
    }
}
