using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosVoucherDetails : EntityRoot
    {
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? Value { get; set; }

        public PosVoucher? PosVoucher { get; set; }

        public string? PosVoucherId { get; set; }

        public string? PayMethodId { get; set; }
        public string? PosNo { get; set; }
    }
}
