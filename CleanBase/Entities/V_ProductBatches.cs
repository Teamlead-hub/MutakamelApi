
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_ProductBatches : EntityRoot
    {
        public string? Barcode { get; set; }
        public string? ProductId { get; set; }


        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ProductionDate { get; set; }

        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? BatchNo { get; set; }
        public decimal? Qty { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? PackagingQty { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
  
        public V_Products? Product { get; set; }
    }
}
