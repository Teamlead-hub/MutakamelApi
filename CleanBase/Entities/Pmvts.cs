using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class Pmvts : EntityRoot
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
        public string? VchrPk { get; set; }
        public decimal? TaxRatio { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? Disc { get; set; }
        public int? Status { get; set; }
        public int? StoreNo { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Tax { get; set; }
        public string? Barcode { get; set; }
        public int? Freetax { get; set; }
        public string? Ref { get; set; }
        public string? note { get; set; }
        public int? PriceFlag { get; set; }
        public decimal? DiscPerc { get; set; }

        public string? InvVoucherId { get; set; }

        public Pinvvoucher? InvVoucher { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? Total { get; set;}

        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalAfterDisc { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? NetTotal { get; set; }

        [NotMapped]
        public string? ArabicName { get; set; }
        [NotMapped]
        public string? EnglishName { get; set; }

        public decimal? PackagingQty { get; set; }
        public string? UnitId { get; set; }
       
        [NotMapped]
        public string? UnitName { get; set; }
        
        public string? BatchNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public int? SampleTestResult { get; set; }
        [NotMapped]
        public string? ProductName { get; set; }
        public int? DiscType { get; set; }
        public string? BonusQty { get; set; }
        public string? CustomerId { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? PriceBeforeTax { get; set; }

        public decimal? DiscValue { get; set; }
        [NotMapped]
        public string? CustomerName { get; set; }
        public string? salesOrderId { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }

        public string? LeadsAndDealsId { get; set; }

    }
}
