using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosInvoiceDetail : EntityRoot
    {
        public PosInvoiceMain? PosInvoiceMain { get; set; }

        public string? PosInvoiceMainId { get; set; }

        public string? ItemNo { get; set; }

        public string? CustomerID { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? Disc { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? AmountBeforeDiscount { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? AmountAfterDiscount { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public string? BarCode { get; set; }

        [Column(TypeName = "numeric(18, 3)")]
        public decimal? TaxRatio { get; set; }

        [Column(TypeName = "numeric(18, 0)")]
        public decimal? OfferPrice { get; set; }

        [Column(TypeName = "numeric(18, 0)")]
        public decimal? OfferDisc { get; set; }

        [Column(TypeName = "numeric(18, 3)")]
        public decimal? ItemTaxAmount { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? ItemBasicPrice { get; set; }

        public string? EItemName { get; set; }

        public bool? IsCustom { get; set; }

        public bool? IsRefund { get; set; }

        public string? ZFile { get; set; }
        public string? PosID { get; set; }
    }
}
