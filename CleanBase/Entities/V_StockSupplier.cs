using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_StockSupplier : EntityRoot
    {
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? TelNumber { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDate { get; set; }

        public string? ManagerPhoneNo { get; set; }
        public string? SalesMangerPhoneNo { get; set; }
        public string? SalesRepPhoneNo { get; set; }
        public string? commericalName { get; set; }
        public string? StockId { get; set; }
        public V_stock? Stock { get; set; }
    }
}
