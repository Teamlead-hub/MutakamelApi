using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class MaterialRequirementsPlanning : EntityRoot
    {
        public string? StockId { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public decimal? LeadTime { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }
        [NotMapped]
        public decimal? ReorderQty { get; set; }
        [NotMapped]
        public decimal? CurrentQty { get; set; }

        public List<MaterialRequirementsPlanningDet> MaterialRequirementsPlanningDet { get; set; } = new List<MaterialRequirementsPlanningDet>();
    }
}
