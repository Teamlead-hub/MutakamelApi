
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class SubAssetsTestMethodSub : EntityRoot
    {
        public string? MaintenanceTestMethodSubId { get; set; }

        [NotMapped]
        public string? SubTestNameAr { get; set; }

        [NotMapped]
        public string? SubTestNameEn { get; set; }
        public string? SubAssetsTestMethodMainId { get; set; }
        public SubAssetsTestMethodMain? SubAssetsTestMethodMain { get; set; }

    }
}
