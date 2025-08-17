using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_VanInvoiceMain : EntityRoot
    {
        public string? VchrNo { get; set; }
        public string? VchrType { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public string? VchrTime { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? DriverId { get; set; }
        public string? PayementMethodId { get; set; }
        public string? PaymentMethodName { get; set; }
        public string? AccountNo { get; set; }
        public string? Accounts_Name { get; set; }

        public decimal? Total { get; set; }
        public string? UUID { get; set; }
        public string? QR { get; set; }
        public string? OriginalUUID { get; set; }
        public string? OriginalInvoiceId { get; set; }
        public string? OriginalTotal { get; set; }
        public string? ReturnNote { get; set; }
        public string? InvvoucherId { get; set; }
        public string? ToStoreNo { get; set; }
        public string? ToStoreName { get; set; }

        public List<V_VanInvoiceDetails> VanInvoiceDetails { get; set; } = new List<V_VanInvoiceDetails>();
    } 
}
