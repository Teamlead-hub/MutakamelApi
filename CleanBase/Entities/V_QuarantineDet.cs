using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_QuarantineDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }
      //  [JsonConverter(typeof(DateOnlyJsonConverter))]
      //  public DateOnly? MvDate { get; set; }
        public decimal? QtyIN { get; set; }
        public decimal? QtyOut { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Cost { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Disc { get; set; }
        public int? StoreNo { get; set; }
        public decimal? Tax   { get; set; }
        public decimal? DiscPerc { get; set;}
        public decimal? NetQty { get; set; }
      
        public string? QuarantineMainId { get; set; }

        public V_QuarantineMain? QuarantineMain { get; set; }
        public decimal? Total {  get; set; }
        public decimal? TotalAfterDisc {  get; set; }
        public decimal? NetTotal { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Packaging { get; set; }
        public decimal? Density { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Volume {  get; set; }
        public string? ColorId { get; set; }
        public string? ColorName { get; set; }
        public decimal? Count { get; set; }
        public string? PackageWeight { get; set; }
        public string? RequestedWeight { get; set; }
        public string? BatchNo { get; set; }
     
        public string? QuantityReceived { get; set; }

      //  [JsonConverter(typeof(DateOnlyJsonConverter))]
      //  public DateOnly? ExpiryDate { get; set; }

        public int? SampleTestResult { get; set; }
        public int? IsDestruction { get; set; }
        public int? IsReturn { get; set; }

    }
}

