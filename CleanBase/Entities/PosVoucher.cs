using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosVoucher : EntityRoot
    {
        public DateTime? VoucherDate { get; set; }

        [Column(TypeName = "numeric(18, 3)")]
        public decimal? Value { get; set; }

        public string? Note { get; set; } // varchar(MAX)

        public int? Status { get; set; }

        public string? PosNo { get; set; }

        public bool? IsUsed { get; set; }

        public string? ZFile { get; set; }

        public List<PosVoucherDetails> VoucherDetails { get; set; } = new List<PosVoucherDetails>();

    }
}
