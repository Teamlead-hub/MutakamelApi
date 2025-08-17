using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_mvts_ProductOrderPackaging : EntityRoot
    {
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? Packaging { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? ColorId { get; set; }
        public string? ColorName { get; set; }
        public decimal? QtyOut { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Tax { get; set; }
        public string? InvVoucherId { get; set; }
        public string? ProductOrderId { get; set; }
        public string? PackagingStockId { get; set; }

    }
}

