using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Assets : EntityRoot
    {
        public string? Asset_Desc { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Accumulate_Dep { get; set; }
        public decimal? Dep_percent { get; set; }
        public string? AccountNo { get; set; }
        [NotMapped]
        public string? accountname { get; set; }
        public string? Dep_Account { get; set; }
        [NotMapped]
        public string? dep_acc_name { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DateLastCalculate { get; set; }
        public string? Exp_Account { get; set; }
        [NotMapped]
        public string? Exp_Acc_name { get; set; }
        public string? AssetCatNo { get; set; }
        [NotMapped]
        public string? catname { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? PurchDate { get; set; }

        public decimal? Lifeexpectancy { get; set; }
        public decimal? ExpectedScrapValue { get; set; }
        public string? Dep_Method { get; set; }
        [NotMapped]
        public string? MethodDesc { get; set; }
        public string? StoreId { get; set; }
        [NotMapped]
        public string? StoreName { get; set; }
        public string? SectionId { get; set; }
        [NotMapped]
        public string? SectionName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? LastMaintinaceDate { get; set; }
        public decimal? MaintinanceValue { get; set; }
        public string? AssetStatus { get; set; }
        public decimal? Qty { get; set; }
        [NotMapped]
        public decimal? ActualAmount { get; set; }
        public string ? AssetPurchaseId { get; set; }

    }
}
