
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_StockBatches : EntityRoot
    {
        public int? BatchNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ProductionDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ReceivedDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public decimal? Qty { get; set; }
        public int? FlagStatus { get; set; }
        public int? StockDetKey { get; set; }

        public string? StockId { get; set; }
       public V_stock? Stock { get; set; }
    }
}
