using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductPackagingReady : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Cost { get; set; }
        public string? StockBatchNo { get; set; }
        public string? StoreNo { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? ActualQty { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? PackagingQty { get; set; }
        public string? FinalProductName { get; set; }
        public string? Barcode { get; set; }
        public string? CartonBarcode { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? Weight { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? TotalStandardCost { get; set; }
    }
}
