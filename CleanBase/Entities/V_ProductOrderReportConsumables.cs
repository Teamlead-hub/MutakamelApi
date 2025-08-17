
using System.ComponentModel.DataAnnotations.Schema;


namespace CleanBase.Entities
{
    public class V_ProductOrderReportConsumables : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public V_ProductOrderReport? ProductOrderReport { get; set; }
        public string? ProductionConsumablesId { get; set; }

        public string? ConsumableName { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal? QtyConsumed { get; set; }
    }
}
