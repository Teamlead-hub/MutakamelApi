using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class CostCenter: EntityRoot
    {

        public string? CostCenterName { get; set; }
        public string? CostCenterNameEn { get; set; }
        public string? CostCenterTypesId { get; set; }
        public string? AccountNo { get; set; }
        public decimal? LastSerial { get; set; }
        public string? ParentId { get; set; }

    }
}
