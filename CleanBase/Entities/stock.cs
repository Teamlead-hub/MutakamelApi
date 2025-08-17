using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Stock : EntityRoot
    {
        public string? ItemType { get; set; }
        public string? ScientificName { get; set; }
        public string? commercialName { get; set; }
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

        public decimal? Concentration { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Density { get; set; }

        [NotMapped]
        public string? ColorName { get; set; }

        public string? ColorId { get; set; }
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
        [Column(TypeName = "numeric(18,4)")]
        public decimal? ReorderQty { get; set; }

        [NotMapped]
        public decimal? Balance { get; set; }

        [NotMapped]
        public decimal? StartYearQty { get; set; }

        [NotMapped]
        public decimal? QtyRecieved { get; set; }

        [NotMapped]
        public decimal? QtyIssue { get; set; }

        [NotMapped]
        public DateOnly? Date_Last_issu { get; set; }

        [NotMapped]
        public DateOnly? Date_last_update { get; set; }

        [NotMapped]
        public DateOnly? Date_Last_Rcvd { get; set; }

        public decimal? Packaging { get; set; }
        public string? StorageLocation { get; set; }
        public string? StorageConditions { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? Notes { get; set; }
        public decimal? MaxQty { get; set; }

        [NotMapped]
        public int? RecordExists { get; set; }
        public string? Barcode { get; set; }
        [NotMapped]
        public string? AllCommercialName { get; set; }
        [NotMapped]
        public decimal? QtyWater { get; set; }
        [NotMapped]
        public decimal? QtySalt { get; set; }

        //Gets The Details of the Suppliers
        public List<StockSupplier> StockSupplier { get; set; } = new List<StockSupplier>();
        public List<StockSpec>? StockSpec { get; set; } = new List<StockSpec>();
        
        //public List<StockTest>? StockTest { get; set; } = new List<StockTest>();
        //[NotMapped]
        //public List<StockPurchase>? StockPurchase { get; set; } = new List<StockPurchase>();

        //[NotMapped]
        //public List<StockStore>? StockStore { get; set; } = new List<StockStore>();


    }
}
