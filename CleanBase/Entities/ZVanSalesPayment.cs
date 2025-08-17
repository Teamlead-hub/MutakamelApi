using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ZVanSalesPayment : EntityRoot
    {
        public decimal? PaymentValue { get; set; }
        public int? PaymentType { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? PaymentDate { get; set; }
        public string? ZVanSalesMainId { get; set; }
        public string? CustomerId { get; set; }
        [NotMapped]
        public string? CustomerName { get; set; }
        public ZVanSalesMain? ZVanSalesMain { get; set; }
        public List<ZVanSalesChecks> Checks { get; set; } = new List<ZVanSalesChecks>();
    }
}

