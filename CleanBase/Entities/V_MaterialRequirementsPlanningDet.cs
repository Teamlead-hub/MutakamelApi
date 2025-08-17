using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaterialRequirementsPlanningDet : EntityRoot
    {
        public string? Week { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public decimal? AvailableQty { get; set; }
        public decimal? ReceivingQty { get; set; }
        public decimal? OrderReleaseQty { get; set; }
        public decimal? DemandQty { get; set; }
        public string? MaterialRequirementsPlanningId { get; set; }
        public V_MaterialRequirementsPlanning? MaterialRequirementsPlanning { get; set; }
    }
}
