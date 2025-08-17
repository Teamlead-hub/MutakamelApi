using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class MaterialRequirementsPlanningDet : EntityRoot
    {
        public string? Week { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public decimal? AvailableQty { get; set; }
        public decimal? ReceivingQty { get; set; }
        public decimal? OrderReleaseQty { get; set; }
        [NotMapped]
        public decimal? DemandQty { get; set; }
        public string? MaterialRequirementsPlanningId { get; set; }
        public MaterialRequirementsPlanning? MaterialRequirementsPlanning { get; set; }
    }
}
