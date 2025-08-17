using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ZVanSalesPayment : EntityRoot
    {
        public decimal? PaymentValue { get; set; }
        public int? PaymentType { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? PaymentDate { get; set; }
        public string? ZVanSalesMainId { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public V_ZVanSalesMain? ZVanSalesMain { get; set; }
        public List<V_ZVanSalesChecks> Checks { get; set; } = new List<V_ZVanSalesChecks>();
    }
}

