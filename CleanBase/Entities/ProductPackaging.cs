using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductPackaging : EntityRoot
    {

        public string? StockId { get; set; }
        [NotMapped]
        public string? ArabicName { get; set; }
        [NotMapped]
        public string? EnglishName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? PackageQuantity { get; set; }
        public string? ProductId { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Weight { get; set; }
        [NotMapped]
        public string? UnitId { get; set; }
        [NotMapped]
        public string? UnitName { get; set; }
        [NotMapped]
        public decimal? TaxRatio { get; set; }
        [NotMapped]
        public decimal? Packaging { get; set; }
        public string? Barcode { get; set; }
        public string? CartonBarcode { get; set; }


        public Products? Product { get; set; }

        public List<ProductPackagingMaterial> ProductPackagingMaterial  { get; set; } =new List<ProductPackagingMaterial>();
    }
}
