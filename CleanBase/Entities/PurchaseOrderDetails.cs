using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class PurchaseOrderDetails : EntityRoot
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
        [NotMapped]
        public string? ColorName { get; set; }
        public PurchaseOrderMain? PurchaseOrderMain { get; set; }

        public decimal? Packaging { get; set; }
        public string ?UnitId {  get; set; }
        [NotMapped]
        public string? UnitName {  get; set; }
    }
}
    
      
  
     