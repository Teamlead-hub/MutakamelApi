using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ZVanSalesDetails : EntityRoot
    {
        public string? Barcode { get; set; }
        public decimal? quantity { get; set; }
        public string? productType { get; set; }
        public string? ProductId { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? ProductName { get; set; }
        public string? ZVanSalesMainId { get; set; }
        public V_ZVanSalesMain? ZVanSalesMain { get; set; }

    }
}

