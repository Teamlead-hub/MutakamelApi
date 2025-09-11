using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class LetterOfCredit : EntityRoot
    {

        public int? LC_ID { get; set; }

        public string? LC_Number { get; set; }


        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OpeningDate {  get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpiryDate { get; set; }

        public string? LC_Type { get; set; }

        public string? PaymentType { get; set; }

        public decimal? TotalValue { get; set; }

        public int? Contract_ID { get; set; }

         public string? Id_Status { get; set; }

        [NotMapped]
        public string? LC_STATUS { get; set; }

        public string? Id_Bank {  get; set; }

        [NotMapped]
        public string? BankName { get; set; }

        public string? Id_Currency { get; set; }

        [NotMapped]
        public string? CurrencyName { get; set; }

        public List<LcDocs>? LcDocs { get; set; } = new List<LcDocs>();


    }
}
