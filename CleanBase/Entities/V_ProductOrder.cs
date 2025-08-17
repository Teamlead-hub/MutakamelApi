using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrder : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OrderDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DateIssueStock { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DateProduct { get; set; }

        public string? ProductId { get; set; }

        public string? ProductOrderReportId { get; set; }

        public string? OrderType { get; set; }

        public string? ProductName { get; set; }

        public string? FactoryId { get; set; }

        public string? FactoryName { get; set; }

        public string? ProductLine { get; set; }

        public string? ProductLineName { get; set; }

        public string? ProductManager { get; set; }

        public string? ManagerName { get; set; }

        public decimal? TargetQty { get; set; }

        public decimal? Volume { get; set; }

        public decimal? Density { get; set; }

        public decimal? Weight { get; set; }

        public decimal? ExpectedHours { get; set; }

        public decimal? ActualHours { get; set; }

        public string? ProductOrderBatch { get; set; }

        public int? Voucher_check { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ReportDate { get; set; }

        public int? HasPerfume { get; set; }
        public int? HasColor { get; set; }
        public decimal? TotalRawMaterialQty { get; set; }

        public List<V_ProductOrderPackaging> ProductOrderPackaging { get; set; } = new List<V_ProductOrderPackaging>();

        public List<V_ProductOrderRawMaterial> ProductOrderRawMaterial { get; set; } = new List<V_ProductOrderRawMaterial>();

        public List<V_ProductOrderWages> ProductOrderWages { get; set; } = new List<V_ProductOrderWages>();
    }
}
