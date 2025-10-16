using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosAccountsPaymethod : EntityRoot
    {
        public PosInvoiceMain? PosInvoiceMain { get; set; }

        public string? PosInvoiceMainId { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public string? PayId { get; set; }

        [Column(TypeName = "numeric(18, 3)")]
        public decimal? Total { get; set; }
    }
}
