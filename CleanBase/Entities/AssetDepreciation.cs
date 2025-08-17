using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AssetDepreciation : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? entryDate { get; set; }
        public int? ToMonth { get; set; }
        public string? AssetCatNo { get; set; }
        [NotMapped]
        public string? AsstCatName { get; set; }
        public int? Status { get; set; }
        public List<AssetDepreciationDetails> Det { get; set; } = new List<AssetDepreciationDetails>();
    }
}
