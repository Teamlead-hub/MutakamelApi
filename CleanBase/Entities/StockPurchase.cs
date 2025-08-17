using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class StockPurchase : EntityRoot
    {
        public string? Supplierid { get; set; }
        public string? SupplierName { get; set; }
        public decimal? Cost { get; set; }
        public decimal? QtyIn { get; set; }

        public DateOnly? ProductionDate { get; set; }

        public DateOnly? ReceivedDate { get; set; }

        public string? StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}
