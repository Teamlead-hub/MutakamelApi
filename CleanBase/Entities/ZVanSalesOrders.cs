using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ZVanSalesOrders : EntityRoot
    {
        public string? Barcode { get; set; }
        public string? OrderNo { get; set; }
        [NotMapped]
        public string? ProductId { get; set; }
        [NotMapped]
        public string? ProductName { get; set; }
        [NotMapped]
        public string? StockId { get; set; }
        [NotMapped]
        public string? ArabicName { get; set; }
        public decimal? Quantity { get; set; }
        public string? ZVanSalesMainId { get; set; }
        public ZVanSalesMain? ZVanSalesMain { get; set; }

    }
}

