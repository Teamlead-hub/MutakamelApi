

using CleanBase.Entities;
using System.Drawing;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class V_StockMvts : EntityRoot
    {
        public string? ItemType { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? LocalCost { get; set; }
        public decimal? Packaging { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Density { get; set; }
        public decimal? Volume { get; set; }
        public string? ColorId { get; set; }
        public string? ColorName { get; set; } 
        public string? commercialName { get; set; }
        public string? ScientificName { get; set; }
        public string? SupplierId { get; set; }
        public int? BatchNo { get; set; }


    }
}

