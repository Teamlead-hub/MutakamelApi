using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class CMvts : EntityRoot
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? MvDate { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? QtyIN { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? QtyOut { get; set; }
        public string? VchrPk { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TaxRatio { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Cost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? RetailPrice { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Disc { get; set; }
        public int? Status { get; set; }
        public string? StoreNo { get; set; }
        [NotMapped]
        public string? StoreName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Tax { get; set; }
        public string? Barcode { get; set; }
        public int? Freetax { get; set; }
        public string? Ref { get; set; }
        public string? note { get; set; }
        public decimal? Bonus { get; set; }
        public int? PriceFlag { get; set; }
        public decimal? DiscPerc { get; set; }
        public string? InvVoucherId { get; set; }

        public CInvvoucher? InvVoucher { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Total { get; set;}
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalAfterDisc { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? NetTotal { get; set; }
        [NotMapped]
        public string? ScientificName { get; set; }
        [NotMapped]
        public string? UnitName { get; set; }

        [NotMapped]
        public decimal? Weight { get; set; }

        [NotMapped]
        public decimal? Packaging { get; set; }

        [NotMapped]
        public decimal? Density { get; set; }
        [NotMapped]
        public string? ColorId { get; set; }
        [NotMapped]  
        public string? ColorName { get; set; }

        [NotMapped]
        public decimal? Volume { get; set; }
        public decimal? Count { get; set; }
        public string? PackageWeight { get; set; }
        public string? RequestedWeight { get; set; }
        public int? BatchNo { get; set; }
      
        public string? QuantityReceived { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public int? SampleTestResult { get; set; }
     

    }
}
