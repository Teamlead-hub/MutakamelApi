using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_LetterOfCredit : EntityRoot
    {
        public int? LC_ID { get; set; }

        public string? LC_Number { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OpeningDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }
        public string? LC_Type { get; set; }
        public string? PaymentType { get; set; }

        public decimal? TotalValue { get; set; }

        public int? Contract_ID { get; set; }

        public string? Id_Status { get; set; }

        public string? LC_Status { get; set; }

        public string? Id_Bank { get; set; }

        public string? BankName { get; set; }   
        public string? Id_Currency { get; set; }

        public string? CurrencyName { get; set; }

        public List<V_LcDocs>? LcDocs { get; set; } = new List<V_LcDocs>();
    }
}
