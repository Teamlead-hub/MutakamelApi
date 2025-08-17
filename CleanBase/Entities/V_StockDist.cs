
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_StockDist : EntityRoot
    {
        public decimal? Cost { get; set; }
        public decimal? QtyOut { get; set; }
        public string? InvVoucherId { get; set; }
        public string? StockId { get; set; }
        public int? BatchNo { get; set; }
       public V_stock? Stock { get; set; }
    }
}
