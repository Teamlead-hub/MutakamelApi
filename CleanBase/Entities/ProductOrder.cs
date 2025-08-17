using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrder:EntityRoot
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

        [NotMapped]
        public string? ProductName { get; set; } 

        public string? FactoryId { get; set; }

        [NotMapped]
        public string? FactoryName { get; set; }

        public string? ProductLine { get; set; }

        [NotMapped]
        public string? ProductLineName { get; set; }

        public string? ProductManager { get; set; }

        [NotMapped]
        public string? ManagerName { get; set; }

        public decimal? TargetQty { get; set; }

        public decimal? Volume { get; set; }

        public decimal? Density { get; set; }

        public decimal? Weight { get; set; }

        public decimal? ExpectedHours { get; set; }

        public decimal? ActualHours { get; set; }

        [NotMapped]
        public string? ProductOrderBatch { get; set; }
        [NotMapped]
        public DateOnly? ReportDate { get; set; }
        public int? HasPerfume { get; set; }
        public int? HasColor { get; set; }
        [NotMapped]
        public decimal? TotalRawMaterialQty { get; set; }


        public List<ProductOrderPackaging> ProductOrderPackaging { get; set; } = new List<ProductOrderPackaging>();

        public List<ProductOrderRawMaterial> ProductOrderRawMaterial { get; set; } = new List<ProductOrderRawMaterial>();

        public List<ProductOrderWages> ProductOrderWages { get; set; } = new List<ProductOrderWages>();

    }
}
