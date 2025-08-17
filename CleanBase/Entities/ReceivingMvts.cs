using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class ReceivingMvts : EntityRoot
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? MvDate { get; set; }
        public decimal? QtyIN { get; set; }
        public decimal? QtyOut { get; set; }
        public string? VchrPk { get; set; }
        public decimal? TaxRatio { get; set; }
        [Column(TypeName = "numeric(18,4)")]

        public decimal? Cost { get; set; }
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
        public decimal? Bonus { get; set; }
        public int? PriceFlag { get; set; }
        public decimal? DiscPerc { get; set; }
        public string? ReceivingInvvoucherId { get; set; }

        public ReceivingInvvoucher? ReceivingInvvoucher { get; set; }
        [Column(TypeName = "numeric(18,4)")]

        public decimal? Total { get; set;}
        [Column(TypeName = "numeric(18,4)")]

        public decimal? TotalAfterDisc { get; set; }
        [Column(TypeName = "numeric(18,4)")]

        public decimal? NetTotal { get; set; }

        public string? UnitId { get; set; }
        [NotMapped]
        public string? UnitName { get; set; }

      
        public decimal? Weight { get; set; }

        public decimal? Packaging { get; set; }

     
        public decimal? Density { get; set; }
        [NotMapped]
        public string? ColorId { get; set; }
        [NotMapped]
        public string? ColorName { get; set; }

      
        public decimal? Volume { get; set; }
        public decimal? Count { get; set; }
        public string? BatchNo { get; set; }
      
        public decimal? QuantityReceived { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public int? SampleTestResult { get; set; }
        public decimal? TotWeight { get; set; }
        public decimal? TotVolume { get; set; }
        public decimal? QuantityRequired { get; set; }

    }
}
