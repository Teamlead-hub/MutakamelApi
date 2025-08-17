using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderRawMaterial:EntityRoot
    {
        public ProductOrder? ProductOrder { get; set; }
        public string? ProductOrderId { get; set; }
        public string? StockId { get; set; }

        [NotMapped]
        public string? UnitId { get; set; }
        [NotMapped]
        public string? UnitName { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public decimal? Volume { get; set; }

        [NotMapped]
        public decimal? Weight { get; set; }

        [NotMapped]
        public decimal? Density { get; set; }

        [NotMapped]
        public decimal? Packaging { get; set; }

        [NotMapped]
        public decimal? TaxRatio { get; set; }
        public string? Ratio { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Cost { get; set; }


        public string? ProductsRawId { get; set; }
        [NotMapped]
        public string? RawType { get; set; }
    }
}
