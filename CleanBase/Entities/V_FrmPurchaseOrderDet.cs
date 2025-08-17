using CleanBase.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_FrmPurchaseOrderDet : EntityRoot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Mvno { get; set; }
        public string? PurchaseOrderMainId { get; set; }
        public string? StockId { get; set; }
        public string? Barcode { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public  decimal? Cost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Tax { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Taxratio { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Bonus { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? DiscPerc { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Total { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? TotalAfterDisc { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? NetTotal { get; set; }
        public decimal? Density { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public string? ColorId { get; set; }
        public string? ColorName { get; set; }
        public V_FrmPurchaseOrder? PurchaseOrderMain { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? Packaging { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
    }
}


