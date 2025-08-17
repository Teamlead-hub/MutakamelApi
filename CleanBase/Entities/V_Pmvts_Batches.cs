using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_Pmvts_Batches : EntityRoot
    {
        public string? StockId { get; set; }
        public string? InvVoucherId { get; set; }
        public string? BatchNo { get; set; }
        public string? productId { get; set; }
        public string? ArabicName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? MvDate { get; set; }
        public string? CustomerName { get; set; }
        public decimal? PhoneNo { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Qty { get; set; }
    }
}

