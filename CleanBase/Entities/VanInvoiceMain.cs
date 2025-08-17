using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class VanInvoiceMain : EntityRoot
    {
        public string? VchrNo { get; set; }
        public string? VchrType { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public string? VchrTime { get; set; }
        public string? CustomerId { get; set; }
        [NotMapped]
        public string? CustomerName { get; set; }
        public string? AreaId { get; set; }
        [NotMapped]
        public string? AreaName { get; set; }
        public string? DriverId { get; set; }
        public string? PayementMethodId { get; set; }
        [NotMapped]
        public string? PaymentMethodName { get; set; }
        public string? AccountNo { get; set; }
        [NotMapped]
        public string? Accounts_Name { get; set; }

        public decimal? Total { get; set; }
        public string? UUID { get; set; }
        public string? QR { get; set; }
        public string? OriginalUUID { get; set; }
        public string? OriginalInvoiceId { get; set; }
        public string? OriginalTotal { get; set; }
        public string? ReturnNote { get; set; }
        public string? InvvoucherId { get; set; }
        [NotMapped]
        public string? ToStoreNo { get; set; }
        [NotMapped]
        public string? ToStoreName { get; set; }

        public List<VanInvoiceDetails> VanInvoiceDetails { get; set; } = new List<VanInvoiceDetails>();

    } 
}
