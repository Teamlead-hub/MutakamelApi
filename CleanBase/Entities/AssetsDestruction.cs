using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AssetsDestruction : EntityRoot
  
    {

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DestructionDate { get; set; }
        public string? AssetsId { get; set; }
        [NotMapped]
        public string? Asset_Desc { get; set; }
        public decimal? AssetsValue { get; set; }
        public decimal? SalesValue { get; set; }
        [NotMapped]
        public decimal? DestructionCost { get; set; }
        public string? Notes { get; set; }
    }
}
