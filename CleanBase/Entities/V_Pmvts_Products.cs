using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_Pmvts_Products : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }
        public string? productId { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? MvDate { get; set; }
        public decimal? QtyIN { get; set; }
        public decimal? QtyOut { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Cost { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Disc { get; set; }
        public int? Status { get; set; }
        public int? StoreNo { get; set; }
        public string? StoreName { get; set; }
        public decimal? Tax { get; set; }
        public string? Barcode { get; set; }
        public decimal? DiscPerc { get; set; }
        public string? InvVoucherId { get; set; }
        public V_Pinvvoucher_Products? InvVoucher { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public decimal? NetTotal { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? PackagingQty { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? BatchNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public int? SampleTestResult { get; set; }
        public string ? ProductName { get; set; }
        public int? DiscType { get; set; }
        public string? BonusQty { get; set; }
        public string? CustomerId { get; set; }
        public decimal? PriceBeforeTax { get; set; }
        public decimal? DiscValue { get; set; }
        public string? CustomerName { get; set; }
        public string? salesOrderId { get; set; }
    }
}

