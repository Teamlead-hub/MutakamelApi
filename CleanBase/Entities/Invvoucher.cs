using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class Invvoucher : EntityRoot
    {
        public string? VchrNo { get; set; }
        public string? VchrType { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public string? SupplierId { get; set; }

        [NotMapped]
        public string? SupplierName { get; set; }
        public string? VchrAccountNo { get; set; }

        [NotMapped]
        public string? Accounts_Name { get; set; }
        public string? STOREId { get; set; }

        [NotMapped]
        public string? StoreName { get; set; }

        public string? FactoryId { get; set; }

        [NotMapped]
        public string? FactoryName { get; set; }


        public string? RefNo { get; set; }
        public string? ToStore { get; set; }

        [NotMapped]
        public string? ToStoreName { get; set; }

        public string? VchrNotes { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? VchrSubTotal { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? VchrDisc { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? VchrDiscPer { get; set; }
        public int? DiscByRow { get; set; }
        public int? DiscType { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? VchrTAX { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? VchrTotal { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalAfterDisc { get; set; }
        //public decimal TaxRatio { get; set; }
        public int? Status { get; set; }
        public int? Credit { get; set; }
        public string? VchrSuppInv { get; set; }
        public string? UserName { get; set; }
        public string? PaymentConditions { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DeliveryDate { get; set; }
        public string? ProductOrderId { get; set; }
        [NotMapped]
        public string? ManagerName { get; set; }

        public string? ReceivingInvvoucherId { get; set; }

        public string? SalesOrderMainId { get; set; }
        public string? CustomerId { get; set; }
        [NotMapped]
        public string? CustomerName { get; set; }
        public string? DeliveryMethod { get; set; }

        public string? ShipmentNo { get; set; }
        public string? VehicleNo { get; set; }
        public string? DriverName { get; set; }
        public string? ShippingReceiptNo { get; set; }
        public decimal? PhoneNo { get; set; }
        public string? Adress { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Customs { get; set; }
        public decimal? BankExpenses { get; set; }
        public decimal? TransportationExpenses { get; set; }
        public decimal? OtherImportExpenses { get; set; }
        public decimal? TaxExpenses { get; set; }
        [NotMapped]
        public string? ProductName { get; set; }
        public string? ProductOrderReportId { get; set; }
        [NotMapped]
        public string? MixReportId { get; set; }
        public string? ProductOrderBatch { get; set; }
        public string? VchrSuppInvRet { get; set; }
        public string? StartingTime { get; set; }
        public string? EndingTime { get; set; }
        public string? WorkingHours { get; set; }
        [NotMapped]
        public string? BatchNo { get; set; }
        public List<Mvts> Mvts { get; set; } = new List<Mvts>();
    } 
}
