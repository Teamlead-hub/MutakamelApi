using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_PCustomerList : EntityRoot
    {
       public string? InvVoucherId { get; set; }
        public V_Pinvvoucher? InvVoucher { get; set; }
        public string? CustomerName { get; set; }
        public string? mobile { get; set; }
        public string? CustCatgnNo { get; set; }

        public string? customerCatgname { get; set; }
        public string? classificationNo { get; set; }

        public string? classificationName { get; set; }
        public string? CityNo { get; set; }

        public string? Cityname { get; set; }
        public string? AreaNo { get; set; }

        public string? AreaName { get; set; }
        public int? Taxable { get; set; }
        public int? DiscType { get; set; }
        public decimal? Disc { get; set; }
        public string? Points { get; set; }
        public int? PaymentDays { get; set; }
        public string? CreditLimit { get; set; }
        public string? BalanceCredit { get; set; }
        public decimal? FinalDisc { get; set; }
    }
}

