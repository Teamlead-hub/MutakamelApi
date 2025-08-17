using CleanBase.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_SalesOrder : EntityRoot
    {

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OrderDate { get; set; }

        public string? AccountId { get; set; }
        public string? Accounts_Name { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public decimal? DiscountValue { get; set; }
        public int? DiscountType { get; set; }
        public decimal? SubTotal { get; set; }
        public  decimal?SalesDisc { get; set; }
        public decimal? SalesTax { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public decimal? NetTotal { get; set; }
        public string? UserName { get; set; }
        public decimal?  SuppDisc { get; set; }
        public int? DiscByRow { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpectedDeliveryDate { get; set; }
        public string? DeliveryConditions { get; set; }
        public string? PaymentConditions { get; set; }
        public List<V_SalesOrderDet> SalesOrderDetails { get; set; } = new List<V_SalesOrderDet>();

    }
}






