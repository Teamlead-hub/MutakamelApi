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
    public class V_FillAssetDep : EntityRoot
    {
        
        public decimal? MovNO { get; set; }
        public string? AssetDepreciationId { get; set; }
        public string? AssetsId { get; set; }
        public string? AssetCatNo { get; set; }
        public string? Asset_Desc { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Lifeexpectancy { get; set; }
        public decimal? Accumulate_Dep { get; set; }
        public decimal? ActualAmount { get; set; }
        public int? ToMonth { get; set; }
        public decimal? monthDep { get; set; }
        public decimal? Dep_percent { get; set; }
        public string? Dep_Method { get; set; }
        public string? MethodDesc { get; set; }
        
    }
}
