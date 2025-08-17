using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class PurchaseOrderMain : EntityRoot
    {
        //public string? OrderNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OrderDate { get; set; }

        public string? SupplierID { get; set; }
        [NotMapped]
        public string? SupplierName { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? DiscountValue { get; set; }
        public int? DiscountType { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? SubTotal { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public  decimal? PchrDisc { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? PchrTax { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalAfterDisc { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? NetTotal { get; set; }
        public string? UserName { get; set; }
        public decimal?  SuppDisc { get; set; }
        public int? DiscByRow { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpectedDeliveryDate { get; set; }
        public string? DeliveryConditions { get; set; }
        public string?PaymentConditions { get; set; }
        public int? CurrencyFlag { get; set; }
        public string? CurrencyNo { get; set; }
        public decimal? CurrencyRate { get; set; }
        [NotMapped]
        public string? CurrencyName { get; set; }
        public int? IsLocal { get; set; }
        public string? Country { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public List<PurchaseOrderDetails> PurchaseOrderDetails { get; set; } = new List<PurchaseOrderDetails>();

    }
}

  
      
     
   
     
     