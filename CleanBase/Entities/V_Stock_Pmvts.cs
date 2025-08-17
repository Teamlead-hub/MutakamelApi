

using CleanBase.Entities;
using System.Drawing;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_Stock_Pmvts : EntityRoot
    {
        public string? VchrType { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public decimal? Cost { get; set; }
        public decimal? QtyIn { get; set; }
        public string? productId { get; set; }
        public string? ProductName { get; set; }
        public string? Barcode { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? BatchNo { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? PackagingQty { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
    }
}

