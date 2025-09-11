using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_Cmvts : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Mvno { get; set; }
        public string? StockId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? MvDate { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? QtyIN { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? QtyOut { get; set; }
        public decimal? Bonus { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TaxRatio { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Cost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? RetailPrice { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Disc { get; set; }
        public string? StoreNo { get; set; }
        public string? StoreName { get; set; }
        public decimal? Tax   { get; set; }

        public decimal? DiscPerc { get; set;}
        [Column(TypeName = "numeric(18,4)")]
        public decimal? NetQty { get; set; }
      
        public string? InvVoucherId { get; set; }

        public V_Cinvvoucher? InvVoucher { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Total {  get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalAfterDisc {  get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? NetTotal { get; set; }
        public string? ArabicName { get; set; }
        //public string? EnglishName { get; set; }

        //public string? ScientificName { get; set; }

        //public decimal? Weight { get; set; }

        //public decimal? Packaging { get; set; }
        //public decimal? Density { get; set; }
        //public string? UnitId { get; set; }
        //public string? UnitName { get; set; }
        //public decimal? Volume {  get; set; }
        //public string? ColorId { get; set; }
        //public string? ColorName { get; set; }
        //public decimal? Count { get; set; }
        //public string? PackageWeight { get; set; }
        //public string? RequestedWeight { get; set; }
        //public int? BatchNo { get; set; }
     
        //public string? QuantityReceived { get; set; }

        //[JsonConverter(typeof(DateOnlyJsonConverter))]
        //public DateOnly? ExpiryDate { get; set; }

        //public int? SampleTestResult { get; set; }
        //public string? commercialName { get; set; }
        public string? SupplierId { get; set; }
    }
}

