using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class V_MaterialRequirementsPlanning : EntityRoot
    {
        public string? StockId { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public decimal? LeadTime { get; set; }
        public string? ArabicName { get; set; }
        public decimal? ReorderQty { get; set; }
        public decimal? CurrentQty { get; set; }

        public List<V_MaterialRequirementsPlanningDet> MaterialRequirementsPlanningDet { get; set; } = new List<V_MaterialRequirementsPlanningDet>();
    }
}
