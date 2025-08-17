using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AssetDepreciationDetails : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public decimal MovNO { get; set; }
        public string? AssetDepreciationId { get; set; }
        public string? AssetsId { get; set; }
        [NotMapped]
        public string? AssetCatNo { get; set; }
        [NotMapped]
        public string? Asset_Desc { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        [NotMapped]
        public DateOnly? StartDate { get; set; }
      
        public decimal? Amount { get; set; }
        [NotMapped]
        public decimal? Lifeexpectancy { get; set; }
      
        public decimal? Accumulate_Dep { get; set; }
       
        public decimal? ActualAmount { get; set; }
        public int? ToMonth { get; set; }
        public decimal? monthDep { get; set; }
        public int? Dep_percent { get; set; }
        public string? Dep_Method { get; set; }
        public AssetDepreciation? AssetDepreciation { get; set; }

    }
}
