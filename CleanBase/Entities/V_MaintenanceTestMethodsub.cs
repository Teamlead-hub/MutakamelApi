using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaintenanceTestMethodsub : EntityRoot
    {
        public string? MaintenanceTestMethodMainId { get; set; }
        public string? TestNameAr { get; set; }
        public string? TestNameEn { get; set; }
        public string? SubTestNameAr { get; set; }
        public string? SubTestNameEn { get; set; }
    }
}
