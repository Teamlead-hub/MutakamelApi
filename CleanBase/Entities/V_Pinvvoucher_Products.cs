using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_Pinvvoucher_Products : EntityRoot
    {
        public string? VchrType { get; set; }
        public string? VchrNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public int? Status { get; set; }
        public string? VchrAccountNo { get; set; }
        public string? Accounts_Name { get; set; }
        public string? ProductionOrderId { get; set; }

        public decimal? VchrDiscPer { get; set; }
        public int? DiscType { get; set; }
        public decimal? VchrDisc { get; set; }
        public int? DiscByRow { get; set; }
        public decimal? VchrTAX { get; set; }
        public decimal? VchrTotal { get; set; }
        public decimal? VchrSubTotal { get; set; }
        public string? VchrNotes { get; set; }
        public int? Credit { get; set; }
        public string? VchrSuppInv { get; set; }
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        //public decimal TaxRatio { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public string? STOREId { get; set; }
        public string? StoreName { get; set; }
        public string? FactoryId { get; set; }
        public string? FactoryName { get; set; }
        public string? UserName { get; set; }
        public string? PaymentConditions { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ProductOrderReportId { get; set; }
        public string? ProductOrderId { get; set; }
        public string? MixingReportId { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? DriversId { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? RoundStart { get; set; }
        public string? RoundEnd { get; set; }
        public int? RoundEndFlag { get; set; }
        public string? ToStore { get; set; }
        public string? ToStoreName { get; set; }
        public string? UUID { get; set; }
        public string? QR { get; set; }
        public string? OriginalUUID { get; set; }
        public string? OriginalInvoiceId { get; set; }
        public string? OriginalTotal { get; set; }
        public string? ReturnNote { get; set; }
        public string? RoundId { get; set; }
        public List<V_Pmvts_Products> Mvts { get; set; } = new List<V_Pmvts_Products>();
    } 
}
