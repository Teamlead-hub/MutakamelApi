using CleanBase.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_FrmPurchaseOrder : EntityRoot
    {

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OrderDate { get; set; }

        public string? SupplierID { get; set; }
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
        public string? PaymentConditions { get; set; }
        public int? CurrencyFlag { get; set; }
        public string? CurrencyNo { get; set; }
        public decimal? CurrencyRate { get; set; }
        public string? CurrencyName { get; set; }
        public int? CountorderinReceiving { get; set; }
        public int? IsLocal { get; set; }
        public string? Country { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public List<V_FrmPurchaseOrderDet> PurchaseOrderDetails { get; set; } = new List<V_FrmPurchaseOrderDet>();

    }
}






