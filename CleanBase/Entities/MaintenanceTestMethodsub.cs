using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class MaintenanceTestMethodsub:EntityRoot
    {
        public string? MaintenanceTestMethodMainId { get; set; }
        public MaintenanceTestMethodMain? MaintenanceTestMethodMain { get; set; }
        [NotMapped]
        public string? TestNameAr { get; set; }
        [NotMapped]
        public string? TestNameEn { get; set; }
        public string? SubTestNameAr { get; set; }
        public string? SubTestNameEn { get; set; }
    }
}
