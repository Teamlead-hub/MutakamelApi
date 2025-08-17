using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class SalesOrderDetails : EntityRoot
    {


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public string? PurchaseId { get; set; }
        public string? SalesOrderMainId { get; set; }
        public string? StockId { get; set; }
        public string? Barcode { get; set; }
        public  decimal? Cost { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Taxratio { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscPerc { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public decimal? NetTotal { get; set; }
        public decimal? Dimensions { get; set; }
        public decimal? Weight { get; set; }
        public string? Materials { get; set; }
        public string? Color { get; set; }
        public SalesOrderMain? SalesOrderMain { get; set; }
        



    }
}
    
      
  
     