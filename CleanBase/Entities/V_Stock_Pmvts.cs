

using CleanBase.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_Stock_Pmvts : EntityRoot
    {

        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? productId { get; set; }
        public string? StockId { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public decimal? PackagingQty { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Price { get; set; }

    }
}

