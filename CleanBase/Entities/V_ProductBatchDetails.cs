using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_ProductBatchDetails : EntityRoot
    {
        public string? Barcode { get; set; }
        public string? UnitId { get; set; }
        public string? ProductId { get; set; }
        public string? StockId { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public decimal? PackagingQty { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public string? BatchNo { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? ProductName { get; set; }
        public decimal? Qty { get; set; }
        public string? InvVoucherId { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Cost { get; set; }
        public string? StoreNo { get; set; }
        public string? StoreName { get; set; }
       
    }
}
