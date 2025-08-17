using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_VanInvoiceDetails : EntityRoot
    {
        public string? Barcode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Disc { get; set; }
        public int? DiscType { get; set; }
        public string? VanInvoiceMainId { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Tax { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public V_VanInvoiceMain? VanInvoiceMain { get; set; }

    }
}
