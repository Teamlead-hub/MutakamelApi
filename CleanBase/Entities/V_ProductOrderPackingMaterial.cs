using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderPackingMaterial : EntityRoot
    {
        public V_ProductOrderPackaging? ProductOrderPackaging { get; set; }
        public string? ProductOrderPackagingId { get; set; }
        public string? ProductPackagingMaterialId { get; set; }
        public string? ArabicName { get; set; }
        public string? StockId { get; set; }
        public string? RM_Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyPerPackage { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Packaging { get; set; }
        public decimal? Density { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? PackagingType { get; set; }

    }
}
