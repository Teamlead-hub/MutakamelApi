using CleanBase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductionConsumables : EntityRoot
    {
        public string? ConsumableName { get; set; }

        public string? ConsumableTypeId { get; set; }

        [NotMapped]
        public string? ConsumableTypeNameAr { get; set; }

        public string? FactoryId { get; set; }

        [NotMapped]
        public string? FactoryName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? PurchaseDate { get; set; }

        public decimal? PurchasePrice { get; set; }

        public string? Notes { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? LocalCost { get; set; }
        public decimal? LastLocalCost { get; set; }
        [NotMapped]
        public decimal? Qty { get; set; }


    }
}

