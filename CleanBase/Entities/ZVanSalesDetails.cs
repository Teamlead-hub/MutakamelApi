using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ZVanSalesDetails : EntityRoot
    {
        public string? Barcode { get; set; }
        public decimal? quantity { get; set; }
        public string? productType { get; set; }

        [NotMapped]
        public string? ProductId { get; set; }

        [NotMapped]
        public string? StockId { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }

        [NotMapped]
        public string? ProductName { get; set; }

        public string? ZVanSalesMainId { get; set; }
        public ZVanSalesMain? ZVanSalesMain { get; set; }

    }
}

