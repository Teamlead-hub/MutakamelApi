using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductsSale : EntityRoot
    {
        public string? VchrType { get; set; }
        public string? VchrTypeAr { get; set; }
        public string? VchrTypeEn { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Qty { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public string? ProductId { get; set; }
        public V_Products? Product { get; set; }

    }
}
