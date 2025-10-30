using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_ProductOrder_mvts : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? MvDate { get; set; }
        public decimal? QtyIN { get; set; }
        public decimal? QtyOut { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Cost { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Disc { get; set; }
        public string? StoreNo { get; set; }
        public string? StoreName { get; set; }
        public decimal? Tax { get; set; }
        public decimal? DiscPerc { get; set; }
        public decimal? NetQty { get; set; }

        public string? InvVoucherId { get; set; }

        public V_ProductOrder_InvVoucher? InvVoucher { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public decimal? NetTotal { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Packaging { get; set; }
        public decimal? Density { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Volume { get; set; }
        public string? ColorId { get; set; }
        public string? ColorName { get; set; }
        public decimal? Count { get; set; }
        public string? PackageWeight { get; set; }
        public string? RequestedWeight { get; set; }
        public int? BatchNo { get; set; }

        public string? QuantityReceived { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }

        public int? SampleTestResult { get; set; }
        public string? PackagingStockId { get; set; }
        public string? PackagingType { get; set; }
        public decimal? ExpectedCartonQuantity { get; set; }
        public decimal? packageQuantity { get; set; }
    }
}

