using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_Trans: EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? Trans_AccountNo { get; set; }
        public string? Accounts_Name { get; set; }
        public string? Trans_CostCenterno { get; set; }
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
        public decimal? Balance { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_FDebit { get; set; }

        [Column(TypeName = "numeric(18,3)")]
        public decimal? Trans_Fcredit { get; set; }

        public string? Trans_CurrencyNo { get; set; }
        public decimal? Trans_CurrencyRate { get; set; }
        public string? CurrencyName { get; set; }     
        public string? VouchersId { get; set; }
        public V_Vouchers? Vouchers { get; set; }
    }
}
