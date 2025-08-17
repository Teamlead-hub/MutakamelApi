using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ZVanSalesChecks : EntityRoot
    {
        public string? Check_number { get; set; }
        public decimal? Check_amount { get; set; }
        public string? Bank_number { get; set; }
        public string? Details { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DueDate { get; set; }
        public string? ZVanSalesPaymentId { get; set; }
        public ZVanSalesPayment? ZVanSalesPayment { get; set; }

    }
}

