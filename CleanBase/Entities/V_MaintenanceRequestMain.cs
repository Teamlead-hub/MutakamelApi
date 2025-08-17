using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaintenanceRequestMain:EntityRoot
    {
        public string? AssestNo { get; set; }
        public string? Asset_Desc { get; set; }
        public string? SubAssetsno { get; set; }
        public string? SubAssetsNameAr { get; set; }
        public string? SubAssetsNameEn { get; set; }

        public List<V_MaintenanceRequestDet> Det { get; set; } = new List<V_MaintenanceRequestDet>();
    }
}
