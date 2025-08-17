using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class v_customer : EntityRoot
    {
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
        public int? FinalDiscType { get; set; }
        public List<V_CustomerContact>? CustomerContact { get; set; } = new List<V_CustomerContact>();
    }
}
