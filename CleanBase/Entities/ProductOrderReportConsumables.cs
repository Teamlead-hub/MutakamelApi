

using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class ProductOrderReportConsumables : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public ProductOrderReport? ProductOrderReport { get; set; }
        public string? ProductionConsumablesId { get; set; }

        [NotMapped]
        public string? ConsumableName { get; set; }

        [NotMapped]
        public decimal? PurchasePrice { get; set; }

        public decimal? QtyConsumed { get; set; }
    }
}
