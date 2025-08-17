using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ZVanSalesOrders : EntityRoot
    {
        public string? Barcode { get; set; }
        public string? OrderNo { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public decimal? Quantity { get; set; }
        public string? ZVanSalesMainId { get; set; }
        public V_ZVanSalesMain? ZVanSalesMain { get; set; }

    }
}

