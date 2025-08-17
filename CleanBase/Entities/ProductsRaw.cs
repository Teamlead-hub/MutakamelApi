using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductsRaw:EntityRoot
    {
        public string? StockId { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? EnglishName { get; set; }

        [NotMapped]
        public decimal? Weight { get; set; }

        [NotMapped]
        public decimal? Density { get; set; }

        [NotMapped]
        public decimal? Volume { get; set; }
        [NotMapped]
        public decimal? TaxRatio { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? RawRatio { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? RawQuantity { get; set; }
        public string? RawType { get; set; }
        public string? ProductId { get; set; }
        public Products? Product { get; set; }
    }
}
