using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderPackingMaterial: EntityRoot
    {
        public ProductOrderPackaging? ProductOrderPackaging { get; set; }
        public string? ProductOrderPackagingId { get; set; }
        public string? ProductPackagingMaterialId { get; set; }
        [NotMapped]
        public string? ArabicName { get; set; }
        public string? StockId { get; set; }
        [NotMapped]
        public string? RM_Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyPerPackage { get; set; }

        [NotMapped]
        public string? UnitId { get; set; }
        [NotMapped]
        public string? UnitName { get; set; }
        [NotMapped]
        public decimal? Volume { get; set; }
        [NotMapped]
        public decimal? Weight { get; set; }
        [NotMapped]
        public decimal? Packaging { get; set; }
        [NotMapped]
        public decimal? Density { get; set; }
        [NotMapped]
        public decimal? TaxRatio { get; set; }
        [NotMapped]
        public string? PackagingType { get; set; }
    }
}
