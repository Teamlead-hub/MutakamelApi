using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductPackaging : EntityRoot
    {
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? PackageQuantity { get; set; }
        public string? ProductId { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Weight { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Packaging { get; set; }
        public string? Barcode { get; set; }
        public string? CartonBarcode { get; set; }
        public V_Products? Product { get; set; }

        public List<V_ProductPackagingMaterial> ProductPackagingMaterial { get; set; } = new List<V_ProductPackagingMaterial>();

    }
}
