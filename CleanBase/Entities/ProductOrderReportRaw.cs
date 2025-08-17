using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderReportRaw : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public ProductOrderReport? ProductOrderReport { get; set; }
        public string? StockId { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? ExpectedQty { get; set; }
        [NotMapped]
        public decimal? QtyOut { get; set; }

        [NotMapped]
        public string? PackageWeight { get; set; }

        [NotMapped]
        public decimal? Tax { get; set; }

        public decimal? Cost { get; set; }
        public int? StockBatchNo { get; set; }
        public string? StoreNo { get; set; }
        public decimal? ActualQty { get; set; }
        public decimal? RestQty { get; set; }
        public decimal? WastedQty { get; set; }
    }
}
