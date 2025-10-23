using CleanBase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderPackaging:EntityRoot
    {
        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? EnglishName { get; set; }
        public string? StockId { get; set; }

        [NotMapped]
        public string? UnitId { get; set; }
        [NotMapped]
        public string? UnitName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Weight { get; set; }
        [NotMapped]
        public decimal? Packaging { get; set; }

        [NotMapped]
        public decimal? Density { get; set; }
        [NotMapped]
        public decimal? TaxRatio { get; set; }
        public decimal? Qty { get; set; }
        public decimal? ExpectedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public string? ProductPackagingId { get; set; }
        public string? ProductOrderId { get; set; }
        public string? ColorId { get; set; }
        [NotMapped]
        public string? ColorName { get; set; }
        public string? PerfumeId { get; set; }
        [NotMapped]
        public string? PerfumeName { get; set; }
        public decimal? PackageQuantity { get; set; }
        [NotMapped]
        public decimal? CartonQuantity { get; set; }
        public decimal? PerfumeQty { get; set; }
        public decimal? ColorQty { get; set; }

        [NotMapped]
        public string? Barcode { get; set; }
        [NotMapped]
        public string? CartonBarcode { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalQuantity { get; set; }

        public string? SubBatch { get; set; }


        public ProductOrder? ProductOrder { get; set; }

        public List<ProductOrderPackingMaterial> ProductOrderPackingMaterial { get; set; } = new List<ProductOrderPackingMaterial>();


    }
}
