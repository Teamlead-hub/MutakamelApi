using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosInvoiceMain : EntityRoot
    {
        public DateTime? InvoiceDate { get; set; }
        public string? PosID { get; set; }
        public string? CustomerID { get; set; }
        [Column(TypeName = "numeric(27, 3)")]
        public decimal? SubTotal { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? Disc { get; set; }
        [Column(TypeName = "numeric(27, 3)")]
        public decimal? DiscPer { get; set; }
        [Column(TypeName = "numeric(27, 3)")]
        public decimal? TotalInvoice { get; set; }
        public string? OperatorID { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? Paid { get; set; }
        public int? hold { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? TaxAmount { get; set; }
        public int? IsFreeTax { get; set; }
        public string? StoreNo { get; set; }
        public string? ZFile { get; set; }
        public List<PosInvoiceDetail> InvoiceDetail { get; set; } = new List<PosInvoiceDetail>();
        public List<PosAccountsPaymethod> AccountsPaymethod { get; set; } = new List<PosAccountsPaymethod>();

    }
}
