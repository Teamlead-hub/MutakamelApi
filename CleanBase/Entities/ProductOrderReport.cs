using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderReport:EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly ReportDate {  get; set; }
        public string? ProductOrderId {  get; set; }
        public string? InvVoucherId {  get; set; }

        [NotMapped]
        public string? ProductId { get; set; }
        [NotMapped]
        public string? ProductName { get; set; }
   
        public decimal? Weight { get; set; }
        [NotMapped]
        public decimal? Volume { get; set; }
        [NotMapped]
        public decimal? Density { get; set; }
        [NotMapped]
        public string? ManagerName { get; set; }
        public decimal? ActualVolume {  get; set; }
        public decimal? WastedVolume {  get; set; }
        public string? Purpose {  get; set; }
        public string? ProblemsFaced {  get; set; }
        public string? Recommendation {  get; set; }
        public string? ReportType {  get; set; }
        public int? BatchMixed { get; set; }
        public string? ProductOrderBatch { get; set; }

        [NotMapped]
        public string? VchrNo { get; set; }

        [NotMapped]
        public string? MixReportId { get; set; }

        [NotMapped]
        public DateOnly? DateProduct { get; set; }

        [NotMapped]
        public int? value_check { get; set; }  //to check if the Production Report has been Recieved 
        [NotMapped]
        public decimal? TotalRawMaterialQty { get; set; }
        [NotMapped]
        public string? BatchNo { get; set; } 

        public List<ProductOrderReportRaw> ProductOrderReportRaw { get; set; } = new List<ProductOrderReportRaw>();
        public List<ProductOrderReportPackaging> ProductOrderReportPackaging { get; set; } = new List<ProductOrderReportPackaging>();
        public List<ProductOrderReportWages> ProductOrderReportWages { get; set; } = new List<ProductOrderReportWages>();
        public List<ProductOrderReportConsumables> ProductOrderReportConsumables { get; set; } = new List<ProductOrderReportConsumables>();
    }
}
