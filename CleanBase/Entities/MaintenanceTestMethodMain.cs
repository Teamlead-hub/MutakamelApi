using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class MaintenanceTestMethodMain : EntityRoot
    {
        public string? TestNameAr { get; set; }
        public string? TestNameEn { get; set; }
        public List<MaintenanceTestMethodsub> MaintenanceTestMethodSub { get; set; } =  new List<MaintenanceTestMethodsub>();

    }
}
