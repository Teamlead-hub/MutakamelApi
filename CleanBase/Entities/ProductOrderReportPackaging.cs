using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderReportPackaging : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public ProductOrderReport? ProductOrderReport { get; set; }
        public string? StockId { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? ProductName { get; set; }

        [NotMapped]
        public decimal? ExpectedQty { get; set; }
        public string? PackingType { get; set; }

        public decimal? Cost { get; set; }

        [NotMapped]
        public decimal? Tax { get; set; }

        public int? StockBatchNo { get; set; }
        public string? StoreNo { get; set; }
        public decimal? ActualQty { get; set; }
        public decimal? RestQty { get; set; }
        public decimal? WastedQty { get; set; }
        public decimal? PackageQuantity { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Weight { get; set; }
        [NotMapped]
        public string? PackageWeight { get; set; }
        public decimal? ActualCartonQuantity { get; set; }
        [NotMapped]
        public decimal? ExpectedCartonQuantity { get; set; }

    }
}
