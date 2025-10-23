using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderReport:EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly ReportDate { get; set; }
        public string? ProductOrderId { get; set; }
        public string? InvVoucherId { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Density { get; set; }
        public string? ManagerName { get; set; }
        public decimal? ActualVolume { get; set; }
        public decimal? WastedVolume { get; set; }
        public string? Purpose { get; set; }
        public string? ProblemsFaced { get; set; }
        public string? Recommendation { get; set; }
        public int? BatchMixed { get; set; }
        public string? ReportType { get; set; }
        public string? ProductOrderBatch { get; set; }
        public string? VchrNo { get; set; }
        public int? value_check { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DateProduct { get; set; }
        public string? MixReportId { get; set; }
        public decimal? TotalRawMaterialQty { get; set; }
        public string? BatchNo { get; set; }
        public string? StartingTime { get; set; }
        public string? EndingTime { get; set; }
        public string? WorkingHours { get; set; }
        public decimal? Wastagerate { get; set; }

        public string? FactoryId { get; set; }
        public string? FactoryName { get; set; }
        public string? ProductLine { get; set; }
        public string? ProductLineName { get; set; }
        public string? ProductManager { get; set; }


        public List<V_ProductOrderReportRaw> ProductOrderReportRaw { get; set; } = new List<V_ProductOrderReportRaw>();
        public List<V_ProductOrderReportPackaging> ProductOrderReportPackaging { get; set; } = new List<V_ProductOrderReportPackaging>();
        public List<V_ProductOrderReportWages> ProductOrderReportWages { get; set; } = new List<V_ProductOrderReportWages>();
        public List<V_ProductOrderReportConsumables> ProductOrderReportConsumables { get; set; } = new List<V_ProductOrderReportConsumables>();
    }
}
