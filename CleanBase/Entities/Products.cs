using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Products : EntityRoot
    {
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? SubcategoryId { get; set; }

        [NotMapped]
        public string? SubcatName { get; set; }

        public string? CategoryId { get; set; }

        [NotMapped]
        public string? CatName { get; set; }

        public string? UnitId { get; set; }

        [NotMapped]
        public string? UnitName { get; set; }

        public string? BrandsId { get; set; }

        [NotMapped]
        public string? BrandName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Density { get; set; }

        [Column(TypeName = "numeric(18,4)")]
        public decimal? LocalCost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? LastLocalCost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? ForeignCost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? LastForeignCost { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? MinQty { get; set; }
        public decimal? ReproduceQty { get; set; }

        [NotMapped]
        public decimal? Balance { get; set; }

        [NotMapped]
        public decimal? StartYearQty { get; set; }

        [NotMapped]
        public decimal? QtyRecieved { get; set; }

        [NotMapped]
        public decimal? QtyIssue { get; set; }

        [NotMapped]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date_Last_issu { get; set; }

        [NotMapped]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date_last_update { get; set; }

        [NotMapped]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date_Last_Rcvd { get; set; }

        public int? Packaging { get; set; }
        public string? StorageLocation { get; set; }
        public string? StorageConditions { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? Notes { get; set; }
        public decimal? MaxQty { get; set; }
        [NotMapped]
        public int? RecordExists { get; set; }
        public string? Barcode { get; set; }

        public List<ProductPackaging>? ProductPackaging { get; set; } = new List<ProductPackaging>();
        public List<ProductSpecs>? ProductSpecs { get; set; } = new List<ProductSpecs>();
        //public List<Productstest>? Productstest { get; set; } = new List<Productstest>();
        public List<ProductsRaw>? ProductsRaw { get; set; } = new List<ProductsRaw>();
        public List<ProductsBarcodes>? ProductsBarcodes { get; set; } = new List<ProductsBarcodes>();

    }
}
