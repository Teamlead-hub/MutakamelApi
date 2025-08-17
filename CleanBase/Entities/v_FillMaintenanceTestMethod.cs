using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class v_FillMaintenanceTestMethod : EntityRoot
    {
        public string? M_TestMethodMainNo { get; set; }
        public string? TestNameAr { get; set; }
        public string? TestNameEn { get; set; }
        public string? M_TestMethodSubNo { get; set; }
        public string? SubTestNameAr { get; set; }
        public string? SubTestNameEn { get; set; }
        public string? SubAssetsId { get; set; }
    }
}
