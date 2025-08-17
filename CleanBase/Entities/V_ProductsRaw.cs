using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class V_ProductsRaw:EntityRoot
    {
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Density { get; set; }
        public decimal? Volume { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? RawRatio { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? RawQuantity { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? RawType { get; set; }
        public string? ProductId { get; set; }
        public V_Products? Product { get; set; }
    }
}
