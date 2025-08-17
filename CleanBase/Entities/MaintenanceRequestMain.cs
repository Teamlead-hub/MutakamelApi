using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class MaintenanceRequestMain : EntityRoot
    {
        public string? AssestNo { get; set; }
        [NotMapped]
        public string? Asset_Desc { get; set; }
        public string? SubAssetsno { get; set; }
        [NotMapped]
        public string? SubAssetsNameAr { get; set; }
        [NotMapped]
        public string? SubAssetsNameEn { get; set; }

        public List<MaintenanceRequestDet> Det { get; set; } = new List<MaintenanceRequestDet>();
    }
}
