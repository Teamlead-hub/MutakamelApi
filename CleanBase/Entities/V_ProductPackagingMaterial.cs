using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductPackagingMaterial : EntityRoot
    {
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? PackagingType { get; set; }
        public string? ProductPackagingId { get; set; }
        public V_ProductPackaging? ProductPackaging { get; set; }
    }
}
