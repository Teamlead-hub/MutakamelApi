using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderReportPackaging : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public V_ProductOrderReport? ProductOrderReport { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? ProductName { get; set; }
        public decimal? ExpectedQty { get; set; }
        public string? PackingType { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Tax { get; set; }
        public int? StockBatchNo { get; set; }
        public string? StoreNo { get; set; }
        public decimal? ActualQty { get; set; }
        public decimal? RestQty { get; set; }
        public decimal? WastedQty { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? ActualCartonQuantity { get; set; }
        public decimal? ExpectedCartonQuantity { get; set; }
    }
}
