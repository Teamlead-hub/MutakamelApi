using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class StockSupplier : EntityRoot
    {
        public string? SupplierId { get; set; }

        [NotMapped]
        public string? SupplierName { get; set; }

        [NotMapped]
        public string? Address { get; set; }

        [NotMapped]
        public string? Email { get; set; }

        [NotMapped]
        public string? TelNumber { get; set; }

        [NotMapped]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDate { get; set; }

        [NotMapped]
        public string? ManagerPhoneNo { get; set; }

        [NotMapped]
        public string? SalesMangerPhoneNo { get; set; }

        [NotMapped]
        public string? SalesRepPhoneNo { get; set; }

        public string? commericalName { get; set; }
        public string? StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}
