using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductsBarcodes : EntityRoot
    {
        public string? Barcode {  get; set; }
        public decimal? PackagingQty {  get; set; }
        public string? ArabicName {  get; set; }
        public string? ProductName {  get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Price {  get; set; }
        public string? ProductId {  get; set; }
        public string? StockId {  get; set; }
        public V_Products? Product {  get; set; }
    }
}
