
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_ProductionConsumables : EntityRoot
    {
        public string? ConsumableName { get; set; }

        public string? ConsumableTypeId { get; set; }

        public string? ConsumableTypeNameAr { get; set; }

        public string? FactoryId { get; set; }

        public string? FactoryName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? PurchaseDate { get; set; }

        public decimal? PurchasePrice { get; set; }

        public string? Notes { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? LocalCost { get; set; }
        public decimal? LastLocalCost { get; set; }
        public decimal? Qty { get; set; }

    }
}
