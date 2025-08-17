using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_StockDetails : EntityRoot
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int? StockDetKey { get; set; }

        public int? BatchNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ProductionDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ReceivedDate { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public decimal? Qty { get; set; }
        public int? FlagStatus { get; set; }

        public string? StoreNo { get; set; }
        public string? StoreName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public string? SupplierId { get; set; }
        public string? InvvoucherId { get; set; }

        public string? StockId { get; set; }
    }
}
