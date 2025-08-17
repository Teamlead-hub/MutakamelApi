using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_StockPurchase : EntityRoot
    {
        public string? Supplierid { get; set; }
        public string? SupplierName { get; set; }
        public string? VchrType { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Qty { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ProductionDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ReceivedDate { get; set; }

        public string? StockId { get; set; }
        public V_stock? Stock { get; set; }
    }
}
