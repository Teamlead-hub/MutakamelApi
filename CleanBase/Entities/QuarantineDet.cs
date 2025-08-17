using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class QuarantineDet : EntityRoot
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }

       // [JsonConverter(typeof(DateOnlyJsonConverter))]
      //  public DateOnly? MvDate { get; set; }
        public decimal? QtyIN { get; set; }
        public decimal? QtyOut { get; set; }
        public string? VchrPk { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Cost { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Disc { get; set; }
        public int? Status { get; set; }
        public int? StoreNo { get; set; }
        public decimal? Tax { get; set; }
        public string? Barcode { get; set; }
        public int? Freetax { get; set; }
        public string? Ref { get; set; }
        public string? note { get; set; }
        public decimal? Bonus { get; set; }
        public int? PriceFlag { get; set; }
        public decimal? DiscPerc { get; set; }

        public string? QuarantineMainId { get; set; }

        public QuarantineMain? QuarantineMain { get; set; }
     
        public decimal? Total { get; set;}
        public decimal? TotalAfterDisc { get; set; }
        public decimal? NetTotal { get; set; }

       
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
        public string? BatchNo { get; set; }
      
        public string? QuantityReceived { get; set; }

       //[JsonConverter(typeof(DateOnlyJsonConverter))]
       // public DateOnly? ExpiryDate { get; set; }
        public int? SampleTestResult { get; set; }
        public int? IsDestruction { get; set; }
        public int? IsReturn { get; set; }

    }
}
