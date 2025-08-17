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
    public class Trans : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? Trans_AccountNo { get; set; }
        [NotMapped]
        public string? Accounts_Name { get; set; }
        public string? Trans_CostCenterno { get; set; }
        [NotMapped]
        public string? CostCenterName { get; set; }
        public string? Trans_CheckNo { get; set; }


        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? Trans_EntryDate { get; set; }
        public string? Trans_Details { get; set; }
        public int? Trans_Posted { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_Tdebit { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_Tcredit { get; set; }

        [NotMapped]
        public decimal? Balance { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_FDebit { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_Fcredit { get; set; }

          public string? Trans_CurrencyNo { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_CurrencyRate { get; set; }

        [NotMapped]
        public string? CurrencyName { get; set; }
      
        public string? VouchersId { get; set; }
        public Vouchers? Vouchers { get; set; }

    }
}
