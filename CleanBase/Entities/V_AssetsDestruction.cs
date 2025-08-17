using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_AssetsDestruction : EntityRoot
    {

      
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DestructionDate { get; set; } 
        public string? AssetsId { get; set; }
        public string? Asset_Desc { get; set; }   
        public decimal? AssetsValue { get; set; }
        public decimal? SalesValue { get; set; }
        public decimal? DestructionCost { get; set; }
        public string? Notes { get; set; }

    }
}
