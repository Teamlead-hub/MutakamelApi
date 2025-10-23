using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderPackaging : EntityRoot
    {
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? StockId { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Weight { get; set; }
        public decimal? Packaging { get; set; }
        public decimal? Density { get; set; }
        public decimal? Qty { get; set; }
        public decimal? ExpectedCost { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? ActualCost { get; set; }
        public string? ProductPackagingId { get; set; }
        public string? ProductOrderId { get; set; }
        public string? ColorId { get; set; }
        public string? ColorName { get; set; }
        public string? PerfumeId { get; set; }
        public string? PerfumeName { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? CartonQuantity { get; set; }
        public decimal? PerfumeQty { get; set; }
        public decimal? ColorQty { get; set; }
        public string? Barcode { get; set; }
        public string? CartonBarcode { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalQuantity { get; set; }

        public string? SubBatch { get; set; }
        public V_ProductOrder? ProductOrder { get; set; }

        public List<V_ProductOrderPackingMaterial> ProductOrderPackingMaterial { get; set; } = new List<V_ProductOrderPackingMaterial>();

    }
}
