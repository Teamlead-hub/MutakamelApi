using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_BarcodeBatches : EntityRoot
    {
        public string? BatchNo { get; set; }
        public string? ProductId { get; set; }
        public string? StockId { get; set; }
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }
        public string? ArabicName { get; set; }
        public string? InvVoucherId { get; set; }
        public decimal? NetQty { get; set; }
        public decimal? Cost { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
    }
}
