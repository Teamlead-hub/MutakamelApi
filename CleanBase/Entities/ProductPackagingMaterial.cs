using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductPackagingMaterial : EntityRoot
    {
        public string? StockId { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? EnglishName { get; set; }
        public decimal? Qty { get; set; }
        [NotMapped]
        public decimal? TaxRatio { get; set; }
        public string? PackagingType { get; set; }
        public string? ProductPackagingId { get; set; }
        public ProductPackaging? ProductPackaging { get; set; }
    }
}
