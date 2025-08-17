using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_stock : EntityRoot
    {
        public string? ItemType { get; set; }
        public string? ScientificName { get; set; }
        public string? commercialName { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? SubcategoryId { get; set; }

        public string? SubcatName { get; set; }

        public string? CategoryId { get; set; }

        public string? CatName { get; set; }

        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Concentration { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Density { get; set; }

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
        public decimal? MinQty { get; set; }
        public decimal? ReorderQty { get; set; }
        public decimal? StartYearQty { get; set; }
        public decimal? QtyRecieved { get; set; }
        public decimal? Balance { get; set; }
        public decimal? QtyIssue { get; set; }

        public DateOnly? Date_Last_issu { get; set; }

        public DateOnly? Date_last_update { get; set; }

        public DateOnly? Date_Last_Rcvd { get; set; }

        public decimal? Packaging { get; set; }
        public string? StorageLocation { get; set; }
        public string? StorageConditions { get; set; }
        public decimal? TaxRatio { get; set; }
        public string? Notes { get; set; }
        public decimal? MaxQty { get; set; }
        public int? RecordExists { get; set; }
        public string? Barcode { get; set; }
        public string? AllCommercialName { get; set; }

        public decimal? QtyWater { get; set; }
        public decimal? QtySalt { get; set; }

        //Gets The Details of the Suppliers
        // public List<V_StockTest>? StockTest { get; set; } = new List<V_StockTest>();
        public List<V_StockSupplier>? StockSupplier { get; set; } = new List<V_StockSupplier>();
        public List<V_StockSpec>? StockSpec { get; set; } = new List<V_StockSpec>();
        public List<V_StockPurchase> StockPurchase { get; set; } = new List<V_StockPurchase>();
        public List<V_StockStore> StockStore { get; set; } = new List<V_StockStore>();

        public List<V_StockBatches>StockBatches { get; set; } = new List<V_StockBatches>();
        public List<V_StockDist> StockDist { get; set; } = new List<V_StockDist>();

    }
}
