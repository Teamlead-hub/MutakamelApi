using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Products : EntityRoot
    {
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? SubcategoryId { get; set; }
        public string? SubcatName { get; set; }
        public string? CategoryId { get; set; }
        public string? CatName { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? BrandsId { get; set; }
        public string? BrandName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Density { get; set; }
        public decimal? LocalCost { get; set; }
        public decimal? LastLocalCost { get; set; }
        public decimal? ForeignCost { get; set; }
        public decimal? LastForeignCost { get; set; }
        public decimal? MinQty { get; set; }
        public decimal? ReproduceQty { get; set; }
        public decimal? Balance { get; set; }
        public decimal? StartYearQty { get; set; }
        public decimal? QtyRecieved { get; set; }
        public decimal? QtyIssue { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date_Last_issu { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date_last_update { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date_Last_Rcvd { get; set; }

        public int? Packaging { get; set; }
        public string? StorageLocation { get; set; }
        public string? StorageConditions { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? Notes { get; set; }
        public decimal? MaxQty { get; set; }
        public int? RecordExists { get; set; }
        public string? Barcode { get; set; }

        public List<V_ProductPackaging>? ProductPackaging { get; set; } = new List<V_ProductPackaging>();
        public List<V_ProductSpecs>? ProductSpecs { get; set; } = new List<V_ProductSpecs>();
        //public List<V_Productstest>? Productstest { get; set; } = new List<V_Productstest>();
        public List<V_ProductsRaw>? ProductsRaw { get; set; } = new List<V_ProductsRaw>();
        public List<V_ProductBatches>? ProductBatches { get; set; } = new List<V_ProductBatches>();
        public List<V_ProductsBarcodes>? ProductsBarcodes { get; set; } = new List<V_ProductsBarcodes>();
    }
}
