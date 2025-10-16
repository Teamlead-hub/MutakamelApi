using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosPaidIn : EntityRoot
    {
        public DateTime? PaidDate { get; set; }

        public string? PaidName { get; set; }

        [Column(TypeName = "numeric(18, 3)")]
        public decimal? Value { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string? Note { get; set; } 

        public int? Status { get; set; }

        public string? PosNo { get; set; }

        public string? ZFile { get; set; }

    }
}
