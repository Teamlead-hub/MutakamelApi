using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Asset_PurchaseDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int IDd { get; set; }
        public string? Asset_PurchaseId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? PurDate { get; set; }
        public string? Assets_No { get; set; }
       public string? Asset_Desc { get; set; }
        public decimal? Cost { get; set; }
        public int? Qty { get; set; }
        [NotMapped]
        public decimal? TotCost { get; set; }
     
        public int? Posted { get; set; }
        public Asset_Purchase? Asset_Purchase { get; set; }
        public string? AsstCatNo { get; set; }
        [NotMapped]
        public string? AsstCatName { get; set; }
        public string? SerialNumber { get; set; }
        [NotMapped]
        public string? Location { get; set; }
        [NotMapped]
        public string? Department { get; set; }
        public string? StoreId { get; set; }
        public string? SectionId { get; set; }
        [NotMapped]
        public int? SerialNumberFlag { get; set; }
    }
}
