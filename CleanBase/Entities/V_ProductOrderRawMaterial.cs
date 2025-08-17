using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderRawMaterial:EntityRoot
    {
        public V_ProductOrder? ProductOrder { get; set; }
        public string? ProductOrderId { get; set; }
        public string? StockId { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? ArabicName { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Density { get; set; }
        public decimal? Packaging { get; set; }
        public string? Ratio { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Cost { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? ProductsRawId { get; set; }
        public string? RawType { get; set; }
    }
}
