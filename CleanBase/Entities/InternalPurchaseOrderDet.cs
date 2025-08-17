using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class InternalPurchaseOrderDet : EntityRoot
    {


        public string? ItemName { get; set; }
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }     
        public decimal? Total { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Cost { get; set; }
        public string? InternalPurchaseOrderMainId { get; set; }

        public InternalPurchaseOrderMain? InternalPurchaseOrderMain { get; set; }


    }
}




