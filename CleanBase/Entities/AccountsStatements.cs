using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AccountsStatements : EntityRoot
    {
        public int? TransId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Trans_EntryDate { get; set; }
        public string? TypeDesc { get; set; }
        public string? TypeDescAr { get; set; }
        public string? VouchersId { get; set; }
        public int? trans_posted { get; set; }
        public string? trans_details { get; set; }
        public decimal? trans_tdebit { get; set; }
        public decimal? trans_tcredit { get; set; }
        public decimal? Accum_balance { get; set; }
      
    }
}
